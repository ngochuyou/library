using library.application.daos;
using library.application.models;
using library.application.service.services;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace library.application.forms {
    public partial class BookForm: Form {

        private Type type = typeof(Book);

        private BaseDAO dao = Program.dao;

        private Book bookModel = new Book();

        private BookService bookService = new BookService();

        public BookForm() {
            InitializeComponent();
        }

        private void landingFormLabel_Click(object sender, System.EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void renderBookSet() {
            this.bookSet.DataSource = dao.getList<Book>(type);
        }

        private void renderModel() {
            this.bookModelNameInput.Text = this.bookModel.name;
            this.bookModelAuthorInput.Text = this.bookModel.author;
            this.bookModelPriceInput.Value = (Decimal) this.bookModel.price;
            this.bookModelPublisherInput.Text = this.bookModel.publisher;
            this.bookModelPublishedDateInput.Value = this.bookModel.publishDate;
            this.bookModelStockedDateInput.Value = this.bookModel.stockedDate;
        }

        private void returnToDashboardButton_Click(object sender, EventArgs e) {
            this.Close();
            FormState.previousPage.Show();
        }

        private void bookModelNameInput_TextChanged(object sender, EventArgs e) {
            this.bookModel.name = ((TextBox) sender).Text;
        }

        private void bookModelAuthorInput_TextChanged(object sender, EventArgs e) {
            this.bookModel.author = ((TextBox) sender).Text;
        }

        private void bookModelPriceInput_ValueChanged(object sender, EventArgs e) {
            this.bookModel.price = (Double) ((NumericUpDown) sender).Value;
        }

        private void bookModelPublisherInput_TextChanged(object sender, EventArgs e) {
            this.bookModel.publisher = ((TextBox) sender).Text;
        }

        private void bookModelPublishedDateInput_ValueChanged(object sender, EventArgs e) {
            this.bookModel.publishDate = ((DateTimePicker) sender).Value;
        }

        private void bookModelStockedDateInput_ValueChanged(object sender, EventArgs e) {
            this.bookModel.stockedDate = ((DateTimePicker) sender).Value;
        }

        private void BookForm_Load(object sender, EventArgs e) {
            this.bookModelPriceInput.Maximum = Decimal.MaxValue;
            this.bookModelPriceInput.Minimum = 1;
            this.bookModel.price = 1;

            this.bookSet.AllowUserToResizeColumns = true;
            this.bookSet.AutoGenerateColumns = false;
            this.bookSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

            DataGridViewTextBoxColumn publishedDateColumn = new DataGridViewTextBoxColumn();

            publishedDateColumn.Name = "Published date";
            publishedDateColumn.DataPropertyName = "publishDate";
            publishedDateColumn.ReadOnly = true;

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();

            priceColumn.Name = "Price";
            priceColumn.DataPropertyName = "price";
            priceColumn.ReadOnly = true;

            DataGridViewTextBoxColumn stockedDateColumn = new DataGridViewTextBoxColumn();

            stockedDateColumn.Name = "Stocked date";
            stockedDateColumn.DataPropertyName = "stockedDate";
            stockedDateColumn.ReadOnly = true;

            this.bookSet.Columns.Add(idColumn);
            this.bookSet.Columns.Add(nameColumn);
            this.bookSet.Columns.Add(authorColumn);
            this.bookSet.Columns.Add(publisherColumn);
            this.bookSet.Columns.Add(publishedDateColumn);
            this.bookSet.Columns.Add(priceColumn);
            this.bookSet.Columns.Add(stockedDateColumn);
            this.bookSet.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.bookSet.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";
            this.renderBookSet();
        }

        private void bookModelEditButton_Click(object sender, EventArgs e) {
            ServiceResult<Book> result = bookService.validate(this.bookModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.update(this.bookModel, type);

            if (dbResult.isOk()) {
                this.bookSet.DataSource = dao.getList<Book>(type);
                this.bookModel = new Book();
                this.bookModel.price = 1;
                this.renderModel();
            }
        }

        private void bookModelRemoveButton_Click(object sender, EventArgs e) {
            DatabaseOperationResult dbResult = dao.delete(this.bookModel, type);

            if (dbResult.isOk()) {
                this.bookSet.DataSource = dao.getList<Book>(type);
                this.bookModel = new Book();
                this.bookModel.price = 1;
                this.renderModel();
            }
        }

        private void bookModelAddButton_Click(object sender, EventArgs e) {
            ServiceResult<Book> result = bookService.validate(this.bookModel);

            if (!result.isOk()) {
                String message = "";

                foreach(String val in result.messages.Values) {
                    message += $"\n{val}";
                }

                MessageBox.Show(message.Substring(1, message.Length - 1), "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DatabaseOperationResult dbResult = dao.insert(bookService
                .initialize(this.bookModel).model, type);

            if (dbResult.isOk()) {
                this.bookSet.DataSource = dao.getList<Book>(type);
                this.bookModel = new Book();
                this.renderModel();
            }
        }

        private void bookSet_SelectionChanged(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection selectedRows = this.bookSet.SelectedRows;

            if (selectedRows.Count > 0) {
                this.bookModel = dao.getList<Book>(type)
                    .ElementAt(selectedRows[0].Index);
                this.renderModel();
            }
        }
    }
}
