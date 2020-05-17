using System;
using System.Collections.Generic;

namespace library.application.models {
    class LendingReceipt: Model {

        public int id { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime returnDate { get; set; }

        public bool isActive { get; set; }

        public Customer customer { get; set; }

        public List<LendingReceiptDetail> details { get; set; }

        public LendingReceipt() {
            this.createdDate = DateTime.Now;
            this.returnDate = DateTime.Now;
            this.customer = new Customer();
            this.details = new List<LendingReceiptDetail>();
        }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }

    }
}
