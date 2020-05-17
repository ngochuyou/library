using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library.application.models {

    [Table("titles")]
    class Title: Model {
        [Key]
        public int id { get; set; } 
        public String name { get; set; }
        public bool isActive { get; set; }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }
    }
}
