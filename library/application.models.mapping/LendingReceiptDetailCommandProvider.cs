using library.application.daos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace library.application.models.mapping {

    class LendingReceiptDetailCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            
            return model.getId();
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            LendingReceiptDetail detail = (LendingReceiptDetail) model;
            String sql = $"INSERT INTO {tableName} ([book_id], [lending_receipt_id], [is_active]) " +
                "VALUES (@bookId, @receiptId, @isActive)";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@bookId", detail.id.book.id);
            insertCommand.Parameters.AddWithValue("@receiptId", detail.id.receipt.id);
            insertCommand.Parameters.AddWithValue("@isActive", detail.isActive);

            return insertCommand;
        }

        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            LendingReceiptDetail detail = (LendingReceiptDetail) model;
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE book_id = @bookId AND lending_receipt_id = @receiptId";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@bookId", detail.id.book.id);
            deleteCommand.Parameters.AddWithValue("@receiptId", detail.id.receipt.id);

            return deleteCommand;
        }

        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            LendingReceiptDetail detail = (LendingReceiptDetail) model;
            String sql = $"UPDATE {tableName} SET is_active = @isActive WHERE book_id = @bookId AND lending_receipt_id = @receiptId";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@isActive", detail.isActive);

            return updateCommand;
        }

        public Model mapModel(DataRow row) {
            LendingReceiptDetail detail = new LendingReceiptDetail();

            if (row == null) {
                return detail;
            }

            BaseDAO dao = Program.dao;

            detail.id = new LendingReceiptDetailId(dao.getList<Book>(typeof(Book))
                .Where(book => book.id == row.Field<int>("book_id"))
                .FirstOrDefault(), dao.getList<LendingReceipt>(typeof(LendingReceipt))
                .Where(receipt => receipt.id == row.Field<int>("lending_receipt_id"))
                .FirstOrDefault());
            detail.isActive = row.Field<bool>("is_active");

            return detail;
        }

        public DataRow mapDataRow(Model model, DataRow row) {
            LendingReceiptDetail detail = (LendingReceiptDetail) model;

            row["book_id"] = detail.id.book.id;
            row["lending_receipt_id"] = detail.id.receipt.id;
            row["is_active"] = detail.isActive;

            return row;
        }
    }

}
