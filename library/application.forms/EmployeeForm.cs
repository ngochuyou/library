using System;
using System.Windows.Forms;
using System.Linq;
using library.application.models;
using library.application.daos;
using library.application.service.services;

namespace library.application.forms {
    public partial class EmployeeForm: Form {

        private BaseDAO dao = Program.dao;

        private EmployeeService employeeService = new EmployeeService();

        private Employee employeeModel = new Employee();
        
        public EmployeeForm() {
            InitializeComponent();
        }

        private void landingFormLabel_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void returnToDashboardButton_Click(object sender, EventArgs e) {
            this.landingFormLabel_Click(sender, e);
        }

        private void EmployeeForm_Load(object sender, EventArgs e) {
            this.renderTitleComboBox();

            this.employeesSet.AllowUserToResizeColumns = true;
            this.employeesSet.AutoGenerateColumns = false;
            this.employeesSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();

            phoneColumn.Name = "Phone";
            phoneColumn.DataPropertyName = "phone";
            phoneColumn.ReadOnly = true;

            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn();

            titleColumn.Name = "Title";
            titleColumn.DataPropertyName = "titleName";
            titleColumn.ReadOnly = true;

            this.employeesSet.Columns.Add(idColumn);
            this.employeesSet.Columns.Add(fullnameColumn);
            this.employeesSet.Columns.Add(dobColumn);
            this.employeesSet.Columns.Add(addressColumn);
            this.employeesSet.Columns.Add(phoneColumn);
            this.employeesSet.Columns.Add(titleColumn);
            this.employeesSet.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

            this.renderEmployeeSet();
        }

        private void renderTitleComboBox() {
            this.employeeModelTitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.employeeModelTitleComboBox.DisplayMember = "name";
            this.employeeModelTitleComboBox.ValueMember = "id";
            this.employeeModelTitleComboBox.DataSource = dao.getList<Title>(typeof(Title));
        }
        private void renderEmployeeSet() {
            this.employeesSet.DataSource = dao.getList<Employee>(typeof(Employee))
                    .Select(emp => new { emp.id, emp.fullname, emp.dob, emp.address, emp.phone, titleName = emp.title.name })
                    .ToList();
        }

        private void renderModel() {
            this.employeeModelFullnameInput.Text = employeeModel.fullname;
            this.employeeModelDobInput.Value = employeeModel.dob;
            this.employeeModelAddressInput.Text = employeeModel.address;
            this.employeeModelPhoneInput.Text = employeeModel.phone;
            this.employeeModelTitleComboBox.SelectedItem = employeeModel.title;
        }

        private void employeeModelFullnameInput_TextChanged(object sender, EventArgs e) {
            this.employeeModel.fullname = ((TextBox) sender).Text;
        }

        private void employeeModelDobInput_ValueChanged(object sender, EventArgs e) {
            this.employeeModel.dob = ((DateTimePicker) sender).Value;
        }

        private void employeeModelAddressInput_TextChanged(object sender, EventArgs e) {
            this.employeeModel.address = ((TextBox) sender).Text;
        }

        private void employeeModelPhoneInput_TextChanged(object sender, EventArgs e) {
            this.employeeModel.phone = ((TextBox) sender).Text;
        }

        private void employeeModelTitleComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            this.employeeModel.title = dao.getList<Title>(typeof(Title))
                    .ElementAt(((ComboBox) sender).SelectedIndex);
        }

        private void employeeModelAddButton_Click(object sender, EventArgs e) {
            ServiceResult<Employee> result = employeeService.validate(this.employeeModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.insert(employeeService
                .initialize(this.employeeModel).model, typeof(Employee));

            if (dbResult.isOk()) {
                this.employeesSet.DataSource = dao.getList<Employee>(typeof(Employee))
                    .Select(emp => new { emp.id, emp.fullname, emp.dob, emp.address, emp.phone, titleName = emp.title.name })
                    .ToList();
                this.employeeModel = new Employee();
                this.renderModel();
            }
        }

        private void employeesSet_SelectionChanged(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection selectedRows = this.employeesSet.SelectedRows;

            if (selectedRows.Count > 0) {
                this.employeeModel = dao.getList<Employee>(typeof(Employee))
                    .ElementAt(selectedRows[0].Index);
                this.renderModel();
            }
        }

        private void employeeModelRemoveButton_Click(object sender, EventArgs e) {
            DatabaseOperationResult dbResult = dao.delete(this.employeeModel, typeof(Employee));

            if (dbResult.isOk()) {
                this.employeesSet.DataSource = dao.getList<Employee>(typeof(Employee))
                    .Select(emp => new { emp.id, emp.fullname, emp.dob, emp.address, emp.phone, titleName = emp.title.name })
                    .ToList();
                this.employeeModel = new Employee();
                this.renderModel();
            }
        }

        private void employeeModelEditButton_Click(object sender, EventArgs e) {
            ServiceResult<Employee> result = employeeService.validate(this.employeeModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.update(this.employeeModel, typeof(Employee));

            if (dbResult.isOk()) {
                this.employeesSet.DataSource = dao.getList<Employee>(typeof(Employee))
                    .Select(emp => new { emp.id, emp.fullname, emp.dob, emp.address, emp.phone, titleName = emp.title.name })
                    .ToList();
                this.employeeModel = new Employee();
                this.renderModel();
            }
        }
    }
}
