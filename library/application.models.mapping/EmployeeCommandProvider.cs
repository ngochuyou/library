using library.application.daos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace library.application.models.mapping {
    class EmployeeCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 0 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            Employee emp = (Employee) model;
            String sql = $"INSERT INTO {tableName} ([id], [fullname], [dob], [address], [phone], [title_id], [is_active]) " +
                "VALUES (@id, @fullname, @dob, @address, @phone, @title_id, @is_active)";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", emp.id);
            insertCommand.Parameters.AddWithValue("@fullname", emp.fullname);
            insertCommand.Parameters.AddWithValue("@dob", emp.dob);
            insertCommand.Parameters.AddWithValue("@address", emp.address);
            insertCommand.Parameters.AddWithValue("@phone", emp.phone);
            insertCommand.Parameters.AddWithValue("@title_id", emp.title.id);
            insertCommand.Parameters.AddWithValue("@is_active", emp.isActive);

            return insertCommand;
        }
        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE id = @id";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@id", model.getId());

            return deleteCommand;
        }
        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            Employee emp = (Employee) model;
            String sql = $"UPDATE {tableName} SET fullname = @fullname, dob = @dob, address = @address, phone = @phone, is_active = @is_active WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", emp.id);
            updateCommand.Parameters.AddWithValue("@fullname", emp.fullname);
            updateCommand.Parameters.AddWithValue("@dob", emp.dob);
            updateCommand.Parameters.AddWithValue("@address", emp.address);
            updateCommand.Parameters.AddWithValue("@phone", emp.phone);
            updateCommand.Parameters.AddWithValue("@title_id", emp.title.id);
            updateCommand.Parameters.AddWithValue("@is_active", emp.isActive);

            return updateCommand;
        }
        public Model mapModel(DataRow row) {
            Employee employee = new Employee();
            
            if (row == null) {
                return employee;
            }
            
            employee.id = row.Field<int>("id");
            employee.fullname = row.Field<String>("fullname");
            employee.dob = row.Field<DateTime>("dob");
            employee.address = row.Field<String>("address");
            employee.phone = row.Field<String>("phone");
            employee.title = new TitleDAO().findById(row.Field<int>("title_id"));
            employee.isActive = row.Field<bool>("is_active");

            return employee;
        }

        public DataRow mapDataRow(Model model, DataRow rowModel) {
            Employee employee = (Employee) model;

            rowModel["id"] = employee.id;
            rowModel["fullname"] = employee.fullname;
            rowModel["dob"] = employee.dob;
            rowModel["address"] = employee.address;
            rowModel["phone"] = employee.phone;
            rowModel["title_id"] = employee.title.id;
            rowModel["is_active"] = employee.isActive;

            return rowModel;
        }

    }
}
