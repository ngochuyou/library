using library.application.daos;
using library.application.models;
using library.application.service.services;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace library.application.forms {

    public partial class CustomerForm : Form {
    
        private Type customerType = typeof(Customer);

        private BaseDAO dao = Program.dao;

        private Customer customerModel = new Customer();

        private CustomerService customerService = new CustomerService();

        public CustomerForm() {
            InitializeComponent();
        }

        private void landingFormLabel_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void returnToDashboardButton_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void renderCustomerSet() {
            BindingList<CustomerModel> list = new BindingList<CustomerModel>();

            foreach (Customer customer in dao.getList<Customer>(typeof(Customer))) {
                list.Add(new CustomerModel(customer.id, customer.fullname, customer.dob, customer.address, customer.email, customer.expiredDate, customer.debt));
            }

            this.customerSet.DataSource = list;
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            this.customerSet.AllowUserToResizeColumns = true;
            this.customerSet.AutoGenerateColumns = false;
            this.customerSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();

            idColumn.Name = "ID";
            idColumn.DataPropertyName = "id";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn fullnameColumn = new DataGridViewTextBoxColumn();

            fullnameColumn.Name = "Fullname";
            fullnameColumn.DataPropertyName = "fullname";
            fullnameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn dobColumn = new DataGridViewTextBoxColumn();

            dobColumn.Name = "Birthdate";
            dobColumn.DataPropertyName = "dob";
            dobColumn.ReadOnly = true;

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();

            addressColumn.Name = "Address";
            addressColumn.DataPropertyName = "address";
            addressColumn.ReadOnly = true;

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();

            emailColumn.Name = "Email";
            emailColumn.DataPropertyName = "email";
            emailColumn.ReadOnly = true;

            DataGridViewTextBoxColumn expiryColumn = new DataGridViewTextBoxColumn();

            expiryColumn.Name = "Expiry date";
            expiryColumn.DataPropertyName = "expiredDate";
            expiryColumn.ReadOnly = true;

            DataGridViewTextBoxColumn debtColumn = new DataGridViewTextBoxColumn();

            debtColumn.Name = "Debt amount";
            debtColumn.DataPropertyName = "debt";
            debtColumn.ReadOnly = true;

            this.customerSet.Columns.Add(idColumn);
            this.customerSet.Columns.Add(fullnameColumn);
            this.customerSet.Columns.Add(dobColumn);
            this.customerSet.Columns.Add(addressColumn);
            this.customerSet.Columns.Add(emailColumn);
            this.customerSet.Columns.Add(expiryColumn);
            this.customerSet.Columns.Add(debtColumn);
            this.customerSet.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.customerSet.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.renderCustomerSet();
        }

        private void customerSet_SelectionChanged(object sender, EventArgs e) {
            if (this.customerSet.SelectedRows.Count > 0) {
                CustomerModel target = this.customerSet.SelectedRows[0].DataBoundItem as CustomerModel;
                BindingList<CustomerModel> list = (BindingList<CustomerModel>) this.customerSet.DataSource;

                this.customerModel = dao.getList<Customer>(typeof(Customer))
                    .Where(model => model.id == target.id)
                    .FirstOrDefault();
                this.renderModel();
            }
        }

        private void renderModel() {
            this.customerModelFullnameInput.Text = customerModel.fullname;
            this.customerModelDobInput.Value = customerModel.dob;
            this.customerModelAddressInput.Text = customerModel.address;
            this.customerModelEmailInput.Text = customerModel.email;
            this.customerModelexpiredDateInput.Value = customerModel.expiredDate;
        }

        private void customerModelFullnameInput_TextChanged(object sender, EventArgs e) {
            this.customerModel.fullname = ((TextBox) sender).Text;
        }

        private void customerModelEmailInput_TextChanged(object sender, EventArgs e) {
            this.customerModel.email = ((TextBox) sender).Text;
        }

        private void customerModelDobInput_ValueChanged(object sender, EventArgs e) {
            this.customerModel.dob = ((DateTimePicker) sender).Value;
        }

        private void customerModelexpiredDateInput_ValueChanged(object sender, EventArgs e) {
            this.customerModel.expiredDate = ((DateTimePicker) sender).Value;
        }

        private void customerModelAddressInput_TextChanged(object sender, EventArgs e) {
            this.customerModel.address = ((TextBox) sender).Text;
        }

        private void customerModelEditButton_Click(object sender, EventArgs e) {
            if (this.customerSet.SelectedRows.Count == 0) {
                return; 
            }

            ServiceResult<Customer> result = customerService.validate(this.customerModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.update(this.customerModel, customerType);

            if (dbResult.isOk()) {
                DataGridViewRow row = this.customerSet.CurrentRow;

                row.Cells["ID"].Value = this.customerModel.id;
                row.Cells["Fullname"].Value = this.customerModel.fullname;
                row.Cells["Birthdate"].Value = this.customerModel.dob;
                row.Cells["Address"].Value = this.customerModel.address;
                row.Cells["Email"].Value = this.customerModel.email;
                row.Cells["Expiry date"].Value = this.customerModel.expiredDate;
                row.Cells["Debt amount"].Value = this.customerModel.debt;
                this.customerModel = new Customer();
                this.renderModel();
            }
        }

        private void customerModelAddButton_Click(object sender, EventArgs e) {
            ServiceResult<Customer> result = customerService.validate(this.customerModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.insert(customerService
                .initialize(this.customerModel).model, customerType);

            if (dbResult.isOk()) {
                BindingList<CustomerModel> list = (BindingList<CustomerModel>) this.customerSet.DataSource;
                Customer customer = this.customerModel;

                list.Add(new CustomerModel(customer.id, customer.fullname, customer.dob, customer.address, customer.email, customer.expiredDate, customer.debt));
                this.customerSet.DataSource = list;
                this.customerModel = new Customer();
                this.renderModel();
            }
        }

        private void customerModelRemoveButton_Click(object sender, EventArgs e) {
            if (this.customerSet.SelectedRows.Count == 0) {
                return; 
            }

            DatabaseOperationResult dbResult = dao.delete(this.customerModel, customerType);

            if (dbResult.isOk()) {
                BindingList<CustomerModel> list = (BindingList<CustomerModel>) this.customerSet.DataSource;

                list.Remove(this.customerSet.CurrentRow.DataBoundItem as CustomerModel);
                this.customerSet.DataSource = list;
                this.customerModel = new Customer();
                this.renderModel();
            }
        }
    }

    class CustomerModel {
        public int id { get; set; }

        public String fullname { get; set; }

        public DateTime dob { get; set; }

        public String address { get; set; }

        public String email { get; set; }

        public DateTime expiredDate { get; set; }

        public Double debt { get; set; }

        public CustomerModel(int id, String fullname, DateTime dob, String address, String email, DateTime expiredDate, Double debt) {
            this.id = id;
            this.fullname = fullname;
            this.dob = dob;
            this.address = address;
            this.email = email;
            this.expiredDate = expiredDate;
            this.debt = debt;
        }
    }
} 
