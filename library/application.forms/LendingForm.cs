using library.application.daos;
using library.application.models;
using library.application.service.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace library.application.forms {

    public partial class LendingForm: Form {

        private BaseDAO dao = Program.dao;

        private Customer customerModel = new Customer();

        private Book bookModel = null;

        private List<LendingReceiptDetail> lendingDetails = new List<LendingReceiptDetail>();

        private PaymentReceipt paymentReceipt = new PaymentReceipt();

        private LendingReceiptService lendingReceiptService = new LendingReceiptService();

        private PaymentReceiptService paymentReceiptService = new PaymentReceiptService();

        public LendingForm() {
            InitializeComponent();

            this.paymentReceipt = new PaymentReceipt();
            this.paymentReceipt.lendingReceipt = new LendingReceipt();
            this.paymentReceipt.paymentAmount = 0;
            this.paymentReceipt.debtAmount= 0;
        }

        private void landingFormLabel_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void landingFormButton_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void customerPickerOpenButton_Click(object sender, EventArgs e) {
            CustomerPicker customerPicker = new CustomerPicker();

            customerPicker.ShowDialog(this);
        }

        public void onCustomerPicked(int customerId) {
            this.customerModel = dao.getList<Customer>(typeof(Customer))
                .Where(customer => customer.id == customerId)
                .FirstOrDefault();
            this.paymentReceipt.lendingReceipt.customer = this.customerModel;
            Console.WriteLine(this.paymentReceipt.lendingReceipt.customer.fullname);
            this.renderCustomerModel();
        }

        private void renderCustomerModel() {
            this.customerInformation.Text = this.customerModel.id + " - " + this.customerModel.fullname;
        }

        private void renderEmployeeSet() {
            this.employeeSet.DisplayMember = "display";
            this.employeeSet.ValueMember = "id";
            this.employeeSet.DataSource = dao.getList<Employee>(typeof(Employee))
                .Select(employee => new { id = employee.id, display = employee.id + " - " + employee.fullname })
                .ToList();
        }

        private void employeeSet_SelectedIndexChanged(object sender, EventArgs e) {
                this.paymentReceipt.employee = dao.getList<Employee>(typeof(Employee))
                    .ElementAt(((ComboBox) sender).SelectedIndex);
        }

        private void LendingForm_Load(object sender, EventArgs e) {
            this.renderEmployeeSet();
            this.bookSet.AutoGenerateColumns = false;
            this.bookSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();

            idColumn.Name = "ID";
            idColumn.DataPropertyName = "id";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();

            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "name";
            nameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn authorColumn = new DataGridViewTextBoxColumn();

            authorColumn.Name = "Author";
            authorColumn.DataPropertyName = "author";
            authorColumn.ReadOnly = true;

            DataGridViewTextBoxColumn publisherColumn = new DataGridViewTextBoxColumn();

            publisherColumn.Name = "Publisher";
            publisherColumn.DataPropertyName = "publisher";
            publisherColumn.ReadOnly = true;

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();

            priceColumn.Name = "Price";
            priceColumn.DataPropertyName = "price";
            priceColumn.ReadOnly = true;

            this.bookSet.Columns.Add(idColumn);
            this.bookSet.Columns.Add(nameColumn);
            this.bookSet.Columns.Add(authorColumn);
            this.bookSet.Columns.Add(publisherColumn);
            this.bookSet.Columns.Add(priceColumn);
            this.renderBookSet();

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

            this.bookSet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            this.paymentReceipt.lendingReceipt.returnDate = ((DateTimePicker) sender).Value;
        }

        private void renderBookSet() {
            if (this.bookModel == null) {
                this.bookSet.DataSource = dao.getList<Book>(typeof(Book));

                return;
            }

            this.bookSet.DataSource = dao.getList<Book>(typeof(Book))
                .Where(book => book.id == this.bookModel.id || book.name.Contains(this.bookModel.name))
                .ToList();

            return;
        }

        private void bookQueryInput_TextChanged(object sender, EventArgs e) {
            String text = ((TextBox) sender).Text;

            if (text == null || text.Length == 0) {
                this.bookModel = null;
                this.renderBookSet();

                return;
            }

            this.bookModel = new Book();

            if (text.All(char.IsDigit)) {
                try {
                    this.bookModel.id = int.Parse(text);
                } catch (Exception) { }
            }

            this.bookModel.name = text;
            this.renderBookSet();

            return;
        }

        private void bookSet_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            int id = int.Parse(this.bookSet.SelectedRows[0].Cells[0].Value.ToString());
            Book selectedBook = dao.getList<Book>(typeof(Book))
                .Where(book => book.id == id)
                .FirstOrDefault();

            if (selectedBook == null) {
                return;
            }

            if (this.lendingDetails.Where(detail => detail.id.book.id == id).Count() != 0) {
                return;
            }

            LendingReceiptDetail newDetail = new LendingReceiptDetail(new LendingReceiptDetailId(selectedBook, paymentReceipt.lendingReceipt));

            this.lendingDetails.Add(newDetail);
            this.renderItemSet();
        }

        private void renderItemSet() {
            BindingList<LendingDetailModel> list = new BindingList<LendingDetailModel>();

            foreach(LendingReceiptDetail detail in this.lendingDetails) {
                list.Add(new LendingDetailModel(detail.id.book.id, detail.id.book.name, detail.id.book.price));
            }

            this.itemSet.DataSource = list;
        }

        private void itemSetClearButton_Click(object sender, EventArgs e) {
            this.lendingDetails = new List<LendingReceiptDetail>();
            this.renderItemSet();
        }

        private void itemRemoveButton_Click(object sender, EventArgs e) {
            if (this.itemSet.SelectedRows.Count == 0) {
                return;
            }

            this.lendingDetails.Remove(this.lendingDetails
                .Where(detail => detail.id.book.id == int.Parse(this.itemSet.SelectedRows[0].Cells[0].Value.ToString()))
                .FirstOrDefault());
            this.itemSet.Rows.RemoveAt(this.itemSet.SelectedRows[0].Index);
        }

        private void submitLendingButton_Click(object sender, EventArgs e) {
            this.paymentReceipt.lendingReceipt.details = this.lendingDetails;
            ServiceResult<PaymentReceipt> result = paymentReceiptService.initialize(this.paymentReceipt);
            
            if (!result.isOk()) {
                this.renderErrors(result.messages);

                return;
            }

            this.paymentReceipt = result.model;
            result = paymentReceiptService.validate(this.paymentReceipt);
                
            if (!result.isOk()) {
                this.renderErrors(result.messages);

                return;
            }

            DatabaseOperationResult insertResult = paymentReceiptService.insert(this.paymentReceipt);

            if (!insertResult.isOk()) {
                return;
            }

            this.paymentReceipt = new PaymentReceipt();
            this.renderBookSet();
            this.customerModel = new Customer();
            this.renderCustomerModel();
            this.itemSetClearButton_Click(sender, e);
            this.employeeSet_SelectedIndexChanged(this.employeeSet, e);
        }

        public void renderErrors(Dictionary<String, String> messages) {
            String message = "";

            foreach(String val in messages.Values) {
                message += $"\n{val}";
            }

            MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }
    }

    class LendingDetailModel {
        
        public int bookId { get; set; }

        public String bookName { get; set; }

        public double price { get; set; }

        public LendingDetailModel(int id, String name, double price) {
            this.bookId = id;
            this.bookName = name;
            this.price = price;
        }
    }
}
