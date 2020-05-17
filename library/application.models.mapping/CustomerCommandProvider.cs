using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace library.application.models.mapping {
    class CustomerCommandProvider: CommandProvider  {
        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 0 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            Customer customer = (Customer) model;
            String sql = $"INSERT INTO {tableName} ([id], [fullname], [dob], [address], [email], [created_date], [expired_date], [debt], [is_active]) " +
                "VALUES (@id, @fullname, @dob, @address, @email, @created_date, @expired_date, @debt, @is_active)";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", customer.id);
            insertCommand.Parameters.AddWithValue("@fullname", customer.fullname);
            insertCommand.Parameters.AddWithValue("@dob", customer.dob);
            insertCommand.Parameters.AddWithValue("@address", customer.address);
            insertCommand.Parameters.AddWithValue("@email", customer.email);
            insertCommand.Parameters.AddWithValue("@created_date", customer.createdDate);
            insertCommand.Parameters.AddWithValue("@expired_date", customer.expiredDate);
            insertCommand.Parameters.AddWithValue("@debt", customer.debt);
            insertCommand.Parameters.AddWithValue("@is_active", customer.isActive);

            return insertCommand;
        }
        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE id = @id";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@id", model.getId());

            return deleteCommand;
        }
        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            Customer customer = (Customer) model;
            String sql = $"UPDATE {tableName} SET fullname = @fullname, dob = @dob, address = @address, email = @email, created_date = @created_date, expired_date = @expired_date, debt= @debt,is_active = @is_active WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", customer.id);
            updateCommand.Parameters.AddWithValue("@fullname", customer.fullname);
            updateCommand.Parameters.AddWithValue("@dob", customer.dob);
            updateCommand.Parameters.AddWithValue("@address", customer.address);
            updateCommand.Parameters.AddWithValue("@email", customer.email);
            updateCommand.Parameters.AddWithValue("@created_date", customer.createdDate);
            updateCommand.Parameters.AddWithValue("@expired_date", customer.expiredDate);
            updateCommand.Parameters.AddWithValue("@debt", customer.debt);
            updateCommand.Parameters.AddWithValue("@is_active", customer.isActive);

            return updateCommand;
        }
        public Model mapModel(DataRow row) {
            Customer customer = new Customer();

            if (row == null) {
                return customer;
            }

            customer.id = row.Field<int>("id");
            customer.fullname = row.Field<String>("fullname");
            customer.dob = row.Field<DateTime>("dob");
            customer.address = row.Field<String>("address");
            customer.email = row.Field<String>("email");
            customer.createdDate = row.Field<DateTime>("created_date");
            customer.expiredDate = row.Field<DateTime>("expired_date");
            customer.debt = row.Field<Double>("debt");
            customer.isActive = row.Field<bool>("is_active");

            return customer;
        }

        public DataRow mapDataRow(Model model, DataRow rowModel) {
            Customer customer = (Customer) model;

            rowModel["id"] = customer.id;
            rowModel["fullname"] = customer.fullname;
            rowModel["dob"] = customer.dob;
            rowModel["address"] = customer.address;
            rowModel["email"] = customer.email;
            rowModel["created_date"] = customer.createdDate;
            rowModel["expired_date"] = customer.expiredDate;
            rowModel["debt"] = customer.debt;
            rowModel["is_active"] = customer.isActive;

            return rowModel;
        }
    }
}
