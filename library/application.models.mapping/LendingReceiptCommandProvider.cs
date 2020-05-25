using library.application.daos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace library.application.models.mapping {

    class LendingReceiptCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 1 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            LendingReceipt receipt = (LendingReceipt) model;
            String sql = $"INSERT INTO {tableName} ([id], [created_date], [return_date], [customer_id], [is_active]) " +
                "VALUES (@id, @createdDate, @returnDate, @customerId, @isActive);";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", receipt.id);
            insertCommand.Parameters.AddWithValue("@createdDate", receipt.createdDate);
            insertCommand.Parameters.AddWithValue("@returnDate", receipt.returnDate);
            insertCommand.Parameters.AddWithValue("@customerId", receipt.customer.id);
            insertCommand.Parameters.AddWithValue("@isActive", receipt.isActive);
            
            return insertCommand;
        }

        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE id = @id";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@id", model.getId());

            return deleteCommand;
        }

        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            LendingReceipt receipt = (LendingReceipt) model;
            String sql = $"UPDATE {tableName} SET created_date = @createdDate, return_date = @returnDate, customer_id = @customerId, is_active = @isActive WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", receipt.id);
            updateCommand.Parameters.AddWithValue("@createdDate", receipt.createdDate);
            updateCommand.Parameters.AddWithValue("@returnDate", receipt.returnDate);
            updateCommand.Parameters.AddWithValue("@customerId", receipt.customer.id);
            updateCommand.Parameters.AddWithValue("@isActive", receipt.isActive);

            return updateCommand;
        }

        public Model mapModel(DataRow row) {
            LendingReceipt receipt = new LendingReceipt();
            
            if (row == null) {
                return receipt;
            }

            BaseDAO dao = Program.dao;

            receipt.id = row.Field<int>("id");
            receipt.createdDate = row.Field<DateTime>("created_date");
            receipt.returnDate = row.Field<DateTime>("return_date");
            receipt.customer = dao.getList<Customer>(typeof(Customer))
                .Where(customer => customer.id == row.Field<int>("customer_id"))
                .FirstOrDefault();
            receipt.isActive = row.Field<bool>("is_active");

            return receipt;
        }

        public DataRow mapDataRow(Model model, DataRow row) {
            LendingReceipt receipt = (LendingReceipt) model;

            row["id"] = receipt.id;
            row["created_date"] = receipt.createdDate;
            row["return_date"] = receipt.returnDate;
            row["customer_id"] = receipt.customer.id;
            row["is_active"] = receipt.isActive;

            return row;
        }
    }
}
