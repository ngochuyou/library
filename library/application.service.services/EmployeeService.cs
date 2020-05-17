using library.application.models;
using System;
using System.Linq;

namespace library.application.service.services {
    class EmployeeService {

        public ServiceResult<Employee> validate(Employee employee) {
            ServiceResult<Employee> result = new ServiceResult<Employee>();

            if (employee.fullname == null || employee.fullname.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("fullname", "Fullname must not be empty.");
            }

            if (employee.address == null || employee.address.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("address", "Address must not be empty.");
            }

            if (employee.dob == null || employee.dob.Year > DateTime.Now.Year - 18) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("dob", "Employee must be at least 18 year old.");
            }

            if (employee.phone != null && employee.phone.Length != 0 && !employee.phone.All(char.IsDigit)) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("phone", "Phone number can only contain numbers and must be maximum 15 characters long.");
            }

            if (employee.title == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("title", "Title must not be empty.");
            }

            TitleService titleService = new TitleService();
            ServiceResult<Title> titleValidationResult = titleService.validate(employee.title);

            if (!titleValidationResult.isOk()) {
                result.status = ServiceStatus.INVALID;
                
                foreach(String key in titleValidationResult.messages.Keys) {
                    if (titleValidationResult.messages[key] != null) {
                        result.messages.Add($"title.{key}", titleValidationResult.messages[key]);
                    }
                }
            }

            return result;
        }
        public ServiceResult<Employee> initialize(Employee employee) {
            ServiceResult<Employee> result = new ServiceResult<Employee>();

            employee.isActive = true;
            result.model = employee;

            return result;
        }

    }
}
