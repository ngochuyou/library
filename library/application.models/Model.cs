using System;

namespace library.application.models {
    interface Model {

        bool isActive { get; set; }

        object getId();

        void setId(Object id);
    }
}
