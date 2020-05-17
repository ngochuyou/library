using library.application.daos;
using library.application.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace library.application.forms {

    public partial class ReturningForm: Form {

        private BindingList<LendingDetailModel> details = new BindingList<LendingDetailModel>();

        private BaseDAO dao = Program.dao;

        private int targetedPaymentId = 0;

        public ReturningForm() {
            InitializeComponent();
        }

        private void landingFormLabel_Click(object sender, System.EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void landingFormButton_Click(object sender, System.EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void ReturningForm_Load(object sender, System.EventArgs e) {
            this.paymentSet.AutoGenerateColumns = false;
            this.paymentSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();

            idColumn.Name = "ID";
            idColumn.DataPropertyName = "id";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn employeeNameColumn = new DataGridViewTextBoxColumn();

            employeeNameColumn.Name = "Employee name";
            employeeNameColumn.DataPropertyName = "employeeName";
            employeeNameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn customerNameColumn = new DataGridViewTextBoxColumn();

            customerNameColumn.Name = "Customer name";
            customerNameColumn.DataPropertyName = "customerName";
            customerNameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn createdDateColumn = new DataGridViewTextBoxColumn();

            createdDateColumn.Name = "Date";
            createdDateColumn.DataPropertyName = "createdDate";
            createdDateColumn.ReadOnly = true;

            DataGridViewTextBoxColumn paymentAmountColumn = new DataGridViewTextBoxColumn();

            paymentAmountColumn.Name = "Payment Amount";
            paymentAmountColumn.DataPropertyName = "paymentAmount";
            paymentAmountColumn.ReadOnly = true;

            this.paymentSet.Columns.Add(idColumn);
            this.paymentSet.Columns.Add(employeeNameColumn);
            this.paymentSet.Columns.Add(customerNameColumn);
            this.paymentSet.Columns.Add(createdDateColumn);
            this.paymentSet.Columns.Add(paymentAmountColumn);
            this.paymentSet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.renderReceiptSet();

            this.itemSet.AutoGenerateColumns = false;
            this.itemSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();

            itemIdColumn.Name = "ID";
            itemIdColumn.DataPropertyName = "bookId";
            itemIdColumn.ReadOnly = true;

            DataGridViewTextBoxColumn itemNameColumn = new DataGridViewTextBoxColumn();

            itemNameColumn.Name = "Name";
            itemNameColumn.DataPropertyName = "bookName";
            itemNameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn itemPriceColumn = new DataGridViewTextBoxColumn();

            itemPriceColumn.Name = "Price";
            itemPriceColumn.DataPropertyName = "price";
            itemPriceColumn.ReadOnly = true;

            this.itemSet.Columns.Add(itemIdColumn);
            this.itemSet.Columns.Add(itemNameColumn);
            this.itemSet.Columns.Add(itemPriceColumn);
            this.itemSet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.renderItemSet();
        }

        private void renderReceiptSet() {
            BindingList<PaymentReceiptModel> list = new BindingList<PaymentReceiptModel>();

            foreach (PaymentReceipt receipt in dao.getList<PaymentReceipt>(typeof(PaymentReceipt))) {
                list.Add(new PaymentReceiptModel(receipt.id, receipt.employee.fullname, receipt.lendingReceipt.customer.fullname, receipt.lendingReceipt.createdDate, receipt.paymentAmount));
            }

            this.paymentSet.DataSource = list;
        }

        private void paymentSet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            int id = int.Parse(this.paymentSet.SelectedRows[0].Cells[0].Value.ToString());
            this.details = new BindingList<LendingDetailModel>();

            foreach (LendingReceiptDetail selectedDetail in dao.getList<LendingReceiptDetail>(typeof(LendingReceiptDetail))
                    .Where(detail => detail.id.receipt.id == id)) {
                this.details.Add(new LendingDetailModel(selectedDetail.id.book.id, selectedDetail.id.book.name, selectedDetail.id.book.price));
            }

            this.targetedPaymentId = id;
            this.renderItemSet();
        }

        private void renderItemSet() {
            this.itemSet.DataSource = this.details;
        }

        private void returnButton_Click(object sender, EventArgs e) {
            dao.delete(dao.getList<PaymentReceipt>(typeof(PaymentReceipt))
                .Where(payment => payment.id == this.targetedPaymentId)
                .FirstOrDefault(), typeof(PaymentReceipt));
            this.renderReceiptSet();
            this.details = new BindingList<LendingDetailModel>();
            this.renderItemSet();
        }
    }

    class PaymentReceiptModel {

        public int id { get; set; }

        public String employeeName { get; set; }

        public String customerName { get; set; }

        public DateTime createdDate { get; set; }

        public double paymentAmount { get; set; }

        public PaymentReceiptModel(int id, String employeeName, String customerName, DateTime createdDate, double paymentAmount) {
            this.id = id;
            this.employeeName = employeeName;
            this.customerName = customerName;
            this.createdDate = createdDate;
            this.paymentAmount = paymentAmount;
        }

    }
}
