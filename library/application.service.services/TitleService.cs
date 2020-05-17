using library.application.models;

namespace library.application.service.services {
    class TitleService {
        public ServiceResult<Title> validate(Title title) {
            ServiceResult<Title> result = new ServiceResult<Title>();

            if (title.name == null || title.name.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("name", "Name must not be empty.");
            }

            result.status = ServiceStatus.OK;

            return result;
        }
    }

}
