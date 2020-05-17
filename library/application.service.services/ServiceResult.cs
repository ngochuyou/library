using System.Collections.Generic;

namespace library.application.service.services{
    class ServiceResult<T> {

        public T model;

        public ServiceStatus status = ServiceStatus.OK;

        public Dictionary<string, string> messages = new Dictionary<string, string>();

        public bool isOk() {
            return this.status == ServiceStatus.OK;
        }

    }

    enum ServiceStatus {
        OK, INVALID, FAILED
    }
}
