using library.application.service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.application.daos {
    class DatabaseOperationResult {

        public ServiceStatus status = ServiceStatus.OK;

        public String message = "";

        public DatabaseOperationResult() {

        }

        public DatabaseOperationResult(ServiceStatus status, String message) {
            this.status = status;
            this.message = message;
        }

        public bool isOk() {
            return this.status == ServiceStatus.OK;
        }
    }
}
