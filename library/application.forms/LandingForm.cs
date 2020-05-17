using System;
using System.Windows.Forms;

namespace library.application.forms {
    public partial class LandingForm : Form {

        public LandingForm() {
            InitializeComponent();
        }

        private void employeeFormOpenButton_Click(object sender, EventArgs e) {
            EmployeeForm employeeForm = new EmployeeForm();

            FormState.previousPage = this;
            employeeForm.Show(this);

            this.Hide();
        }

        private void customerFormOpenButton_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new CustomerForm();

            FormState.previousPage = this;
            customerForm.Show(this);

            this.Hide();
        }

        private void bookFormOpenButton_Click(object sender, EventArgs e) {
            BookForm bookForm = new BookForm();

            FormState.previousPage = this;
            bookForm.Show(this);

            this.Hide();
        }

        private void lendingFormOpenButton_Click(object sender, EventArgs e) {
            LendingForm lendingForm = new LendingForm();

            FormState.previousPage = this;
            lendingForm.Show(this);

            this.Hide();
        }

        private void returningFormOpenButton_Click(object sender, EventArgs e) {
            ReturningForm returningForm = new ReturningForm();

            FormState.previousPage = this;
            returningForm.Show(this);

            this.Hide();
        }
    }

    public static class FormState {

        public static Form previousPage;

        public static Form parent;

    }

}
