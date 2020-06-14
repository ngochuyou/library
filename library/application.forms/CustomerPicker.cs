using library.application.daos;
using library.application.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace library.application.forms {
    public partial class CustomerPicker : Form {

        private Customer model = null;

        private BaseDAO dao = Program.dao;

        public CustomerPicker() {
            InitializeComponent();
            this.customerSet.AutoGenerateColumns = false;
            this.customerSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();

            idColumn.Name = "ID";
            idColumn.DataPropertyName = "id";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn fullnameColumn = new DataGridViewTextBoxColumn();

            fullnameColumn.Name = "Fullname";
            fullnameColumn.DataPropertyName = "fullname";
            fullnameColumn.ReadOnly = true;

            DataGridViewTextBoxColumn expiredDateColumn = new DataGridViewTextBoxColumn();

            expiredDateColumn.Name = "Expiry Date";
            expiredDateColumn.DataPropertyName = "expiredDate";
            expiredDateColumn.ReadOnly = true;

            DataGridViewTextBoxColumn debtColumn = new DataGridViewTextBoxColumn();

            debtColumn.Name = "Debt amount";
            debtColumn.DataPropertyName = "debt";
            debtColumn.ReadOnly = true;

            this.customerSet.Columns.Add(idColumn);
            this.customerSet.Columns.Add(fullnameColumn);
            this.customerSet.Columns.Add(expiredDateColumn);
            this.customerSet.Columns.Add(debtColumn);
            this.customerSet.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void customerQueryInput_TextChanged(object sender, System.EventArgs e) {
            String text = ((TextBox) sender).Text;

            if (text == null || text.Length == 0) {
                this.model = null;
                this.renderCustomerSet();

                return;
            }

            this.model = new Customer();

            if (text.All(char.IsDigit)) {
                try {
                    this.model.id = int.Parse(text);
                } catch (Exception) { }
            }

            this.model.fullname = text;
            this.renderCustomerSet();

            return;
        }

        private void renderCustomerSet() {
            Console.WriteLine(this.model == null);

            if (this.model == null) {
                this.customerSet.DataSource = dao.getList<Customer>(typeof(Customer))
                    .Where(customer => DateTime.Compare(customer.expiredDate, DateTime.Now) > 0)
                    .ToList();

                return;
            }

            this.customerSet.DataSource = dao.getList<Customer>(typeof(Customer))
                .Where(customer => (DateTime.Compare(customer.expiredDate, DateTime.Now) > 0) && (customer.id == this.model.id || customer.fullname.Contains(this.model.fullname)))
                .ToList();

            return;
        }

        private void CustomerPicker_Load(object sender, EventArgs e) {
            this.renderCustomerSet();
        }

        private void submitCustomerButton_Click(object sender, EventArgs e) {
            if (this.model == null) {
                return;
            }

            LendingForm lendingForm = (LendingForm) this.Owner;

            lendingForm.onCustomerPicked(this.model.id);
            this.Close();
        }

        private void customerSet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            try {
                this.model = new Customer();
                this.model.id = int.Parse(((DataGridView) sender).SelectedRows[0].Cells[0].Value.ToString());
            } catch (Exception) { }
        }
    }
}
