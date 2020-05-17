using library.application.models;
using System;
using System.Net.Mail;

namespace library.application.service.services {
    class CustomerService {

        public ServiceResult<Customer> validate(Customer customer) {
            ServiceResult<Customer> result = new ServiceResult<Customer>();

            if (customer.fullname == null || customer.fullname.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("name", "Fullname must not be empty.");
            }

            if (customer.address == null || customer.address.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("address", "Address must not be empty.");
            }

            if (customer.createdDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("createdDate", "Customer's library card must have a creation date.");
            }
            
            if (customer.email == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("email", "Email address must not be empty.");
            } else {
                try {
                    new MailAddress(customer.email);
                } catch (FormatException) {
                    result.status = ServiceStatus.INVALID;
                    result.messages.Add("email", "Invalid email address.");
                }
            }

            if (customer.expiredDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("expiredDate", "Customer's library card must have a valid expiry date.");
            }

            if (customer.debt < 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("debt", "Invalid debt status.");
            }

            return result;
        }

        public ServiceResult<Customer> initialize(Customer customer) {
            ServiceResult<Customer> result = new ServiceResult<Customer>();

            if (customer.expiredDate == null || customer.expiredDate.Date < DateTime.Now.Date) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("expiredDate", "Customer's library card must be a future date.");
            }

            customer.isActive = true;
            customer.debt = 0;
            customer.createdDate = DateTime.Now;
            result.model = customer;

            return result;
        }

    }
}
