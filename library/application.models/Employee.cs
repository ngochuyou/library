using System;

namespace library.application.models {

    class Employee: Model {

        public int id { get; set; }

        public String fullname { get; set; } 

        public DateTime dob { get; set; } 

        public String address { get; set; } 

        public String phone { get; set; } 

        public Title title { get; set; } 

        public bool isActive { get; set; }
        
        public Employee() {
            this.title = new Title();
            this.dob = DateTime.Now;
        }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }

    }

}
