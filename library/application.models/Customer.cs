using System;

namespace library.application.models {

    class Customer: Model {

        public Customer() {
            this.dob = DateTime.Now;
            this.expiredDate = DateTime.Now;
        }

        public int id { get; set; }

        public bool isActive { get; set; }

        public String fullname { get; set; }

        public DateTime dob { get; set; }

        public String address { get; set; }

        public String email { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime expiredDate { get; set; }

        public Double debt { get; set; }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }

    }
}
