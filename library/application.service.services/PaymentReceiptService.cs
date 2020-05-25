using library.application.daos;
using library.application.models;
using System.Transactions;
using System;
using System.Data.SqlClient;
using library.application.models.mapping;

namespace library.application.service.services {

    class PaymentReceiptService {

        private BaseDAO dao = Program.dao;

        public ServiceResult<PaymentReceipt> validate(PaymentReceipt receipt) {
            ServiceResult<PaymentReceipt> result = new ServiceResult<PaymentReceipt>();

            if (receipt.debtAmount < 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("debtAmount", "Debt amount cannot be negative");
            }

            if (receipt.paymentAmount < 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("paymentAmount", "Payment amount cannot be negative");
            }

            if (receipt.debtAmount > receipt.paymentAmount) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("debtAmount", "Debt amount cannot be greater than payment amount");
            }

            EmployeeService employeeService = new EmployeeService();
            ServiceResult<Employee> employeeValidation = employeeService.validate(receipt.employee);

            if (!employeeValidation.isOk()) {
                result.status = ServiceStatus.INVALID;

                foreach (String key in employeeValidation.messages.Keys) {
                    result.messages.Add($"employee_{key}", employeeValidation.messages[key]);
                }
            }

            LendingReceiptService lendingReceiptService = new LendingReceiptService();
            ServiceResult<LendingReceipt> lendingReceiptValidation = lendingReceiptService.validate(receipt.lendingReceipt);

            if (!lendingReceiptValidation.isOk()) {
                result.status = ServiceStatus.INVALID;

                foreach (String key in lendingReceiptValidation.messages.Keys) {
                    result.messages.Add($"lendingReceipt_{key}", lendingReceiptValidation.messages[key]);
                }
            }

            result.model = receipt;

            return result;
        }

        public ServiceResult<PaymentReceipt> initialize(PaymentReceipt receipt) {
            ServiceResult<PaymentReceipt> result = new ServiceResult<PaymentReceipt>();
            ServiceResult<LendingReceipt> lendingReceiptInitializationResult = new LendingReceiptService().initialize(receipt.lendingReceipt);

            if (!lendingReceiptInitializationResult.isOk()) {
                result.status = ServiceStatus.FAILED;
                result.messages = lendingReceiptInitializationResult.messages;
                result.model = receipt;

                return result;
            }

            receipt.lendingReceipt = lendingReceiptInitializationResult.model;

            foreach (LendingReceiptDetail detail in receipt.lendingReceipt.details) {
                receipt.paymentAmount += detail.id.book.price;
            }

            receipt.isActive = true;
            result.model = receipt;

            return result;
        }

        public DatabaseOperationResult insert(PaymentReceipt receipt) {
            using (TransactionScope transactionScope = new TransactionScope()) {
                DatabaseOperationResult result = new DatabaseOperationResult();
                DatabaseOperationResult lendingReceiptInsertionResult = dao.insert(receipt.lendingReceipt, typeof(LendingReceipt));

                if (!lendingReceiptInsertionResult.isOk()) {
                    result.status = ServiceStatus.INVALID;
                    result.message = "Operation failed when trying to insert Lending Receipt";
                    return result;
                }

                DatabaseOperationResult paymentReceiptInsertionResult = dao.insert(receipt, typeof(PaymentReceipt));

                if (!paymentReceiptInsertionResult.isOk()) {
                    result.status = ServiceStatus.INVALID;
                    result.message = "Operation failed when trying to insert Payment Receipt";
                    return result;
                }

                DatabaseOperationResult lendingDetailsInsertionResult;

                foreach (LendingReceiptDetail detail in receipt.lendingReceipt.details) {
                    lendingDetailsInsertionResult = dao.insert(detail, typeof(LendingReceiptDetail));

                    if (!lendingDetailsInsertionResult.isOk()) {
                        result.status = ServiceStatus.INVALID;
                        result.message = "Operation failed when trying to insert Lending details";
                        return result;
                    }
                }

                transactionScope.Complete();

                return result;
            }
        }
    }
}
