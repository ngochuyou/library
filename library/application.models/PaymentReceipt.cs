using System;

namespace library.application.models {
    class PaymentReceipt: Model {

        public int id { get; set; }

        public double debtAmount { get; set; }

        public double paymentAmount { get; set; }

        public Employee employee  { get; set; }

        public LendingReceipt lendingReceipt { get; set; }

        public bool isActive { get; set; }

        public PaymentReceipt() {
            this.employee = new Employee();
            this.lendingReceipt = new LendingReceipt();
        }

        public object getId() {

            return (object) this.id;
        }

        public void setId(Object id) {
            this.id = (int) id;
        }

    }
}
