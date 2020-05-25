using library.application.daos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace library.application.models.mapping {

    class PaymentReceiptCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 1 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            PaymentReceipt receipt = (PaymentReceipt) model;
            String sql = $"INSERT INTO {tableName} ([id], [debt_amount], [payment_amount], [employee_id], [lending_receipt_id], [is_active]) " +
                "VALUES (@id, @debtAmount, @paymentAmount, @employeeId, @lendingReceiptId, @isActive);";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", receipt.id);
            insertCommand.Parameters.AddWithValue("@debtAmount", receipt.debtAmount);
            insertCommand.Parameters.AddWithValue("@paymentAmount", receipt.paymentAmount);
            insertCommand.Parameters.AddWithValue("@employeeId", receipt.employee.id);
            insertCommand.Parameters.AddWithValue("@lendingReceiptId", receipt.lendingReceipt.id);
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
            PaymentReceipt receipt = (PaymentReceipt) model;
            String sql = $"UPDATE {tableName} SET debt_amount = @debtAmount, payment_amount = @paymentAmount, employee_id = @employeeId, lending_receipt_id = @lendingReceiptId, is_active = @isActive WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", receipt.id);
            updateCommand.Parameters.AddWithValue("@debtAmount", receipt.debtAmount);
            updateCommand.Parameters.AddWithValue("@paymentAmount", receipt.paymentAmount);
            updateCommand.Parameters.AddWithValue("@employeeId", receipt.employee.id);
            updateCommand.Parameters.AddWithValue("@lendingReceiptId", receipt.lendingReceipt.id);
            updateCommand.Parameters.AddWithValue("@isActive", receipt.isActive);

            return updateCommand;
        }

        public Model mapModel(DataRow row) {
            PaymentReceipt receipt = new PaymentReceipt();
            
            if (row == null) {
                return receipt;
            }

            BaseDAO dao = Program.dao;

            receipt.id = row.Field<int>("id");
            receipt.debtAmount = row.Field<Double>("debt_amount");
            receipt.paymentAmount = row.Field<Double>("payment_amount");
            receipt.employee = dao.getList<Employee>(typeof(Employee))
                .Where(employee => employee.id == row.Field<int>("employee_id"))
                .FirstOrDefault();
            receipt.lendingReceipt = dao.getList<LendingReceipt>(typeof(LendingReceipt))
                .Where(lendingReceipt => lendingReceipt.id == row.Field<int>("lending_receipt_id"))
                .FirstOrDefault();
            receipt.isActive = row.Field<bool>("is_active");

            return receipt;
        }

        public DataRow mapDataRow(Model model, DataRow row) {
            PaymentReceipt receipt = (PaymentReceipt) model;

            row["id"] = receipt.id;
            row["debt_amount"] = receipt.debtAmount;
            row["payment_amount"] = receipt.paymentAmount;
            row["employee_id"] = receipt.employee.id;
            row["lending_receipt_id"] = receipt.lendingReceipt.id;
            row["is_active"] = receipt.isActive;

            return row;
        }
    }

}
