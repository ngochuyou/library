using library.application.models;
using System;

namespace library.application.service.services {

    class LendingReceiptService {

        public ServiceResult<LendingReceipt> validate(LendingReceipt receipt) {
            ServiceResult<LendingReceipt> result = new ServiceResult<LendingReceipt>();

            if (receipt.createdDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("createdDate", "Created date must not be empty.");
            }

            if (receipt.returnDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("returnedDate", "Returned date must not be empty.");
            }

            CustomerService customerService = new CustomerService();
            ServiceResult<Customer> customerValidationResult = customerService.validate(receipt.customer);

            if (!customerValidationResult.isOk()) {
                result.status = ServiceStatus.INVALID;

                foreach (String key in customerValidationResult.messages.Keys) {
                    result.messages.Add($"customer_{key}", customerValidationResult.messages[key]);
                }
            }

            if (receipt.details.Count == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("details", "Lending details cannot be empty.");
            }

            result.model = receipt;

            return result;
        }

        public ServiceResult<LendingReceipt> initialize(LendingReceipt receipt) {
            ServiceResult<LendingReceipt> result = new ServiceResult<LendingReceipt>();

            foreach (LendingReceiptDetail detail in receipt.details) {
                detail.id.receipt = receipt;
            }

            receipt.createdDate = DateTime.Now;
            receipt.isActive = true;
            result.model = receipt;

            return result;
        }
    }
}
