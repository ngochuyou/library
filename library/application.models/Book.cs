using System;

namespace library.application.models {
    class Book: Model {

        public Book() {
            this.price = 1;
            this.publishDate = DateTime.Now;
            this.stockedDate = DateTime.Now;
        }

        public int id { get; set; }

        public String name { get; set; }

        public String author { get; set; }

        public DateTime publishDate { get; set; }

        public String publisher{ get; set; }

        public Double price { get; set; }

        public DateTime stockedDate { get; set; }

        public bool isActive { get; set; }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }

    }
}
