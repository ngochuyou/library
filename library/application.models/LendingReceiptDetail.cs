using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.application.models {

    class LendingReceiptDetail: Model {

        public LendingReceiptDetailId id { get; set; }

        public bool isActive { get; set; }

        public LendingReceiptDetail() {
            this.isActive = true;
        }

        public LendingReceiptDetail(LendingReceiptDetailId id) {
            this.id = id;
            this.isActive = true;
        }

        public object getId() {
            return this.id;
        }

        public void setId(Object id) {
            this.id = (LendingReceiptDetailId) id;
        }

    }

    class LendingReceiptDetailId {

        public Book book { get; set; }

        public LendingReceipt receipt { get; set; }

        public LendingReceiptDetailId(Book book, LendingReceipt receipt) {
            this.book = book;
            this.receipt = receipt;
        }
        
    }

}
