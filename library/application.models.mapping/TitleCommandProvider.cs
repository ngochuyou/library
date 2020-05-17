using System;
using System.Data;
using System.Data.SqlClient;

namespace library.application.models.mapping {

    class TitleCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 0 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            Title title = (Title) model;
            String sql = $"INSERT INTO {tableName} ([id], [name], [is_active]) " +
                "VALUES (@id, @name, @is_active)";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", title.id);
            insertCommand.Parameters.AddWithValue("@name", title.name);
            insertCommand.Parameters.AddWithValue("@is_active", title.isActive);

            return insertCommand;
        }

        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE id = @id";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@id", model.getId());

            return deleteCommand;
        }
        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            Title title = (Title) model;
            String sql = $"UPDATE {tableName} SET name = @name, is_active = @is_active WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", title.id);
            updateCommand.Parameters.AddWithValue("@name", title.name);
            updateCommand.Parameters.AddWithValue("@is_active", title.isActive);

            return updateCommand;
        }
        public Model mapModel(DataRow row) {
            Title title = new Title();
            
            if (row == null) {
                return title;
            }
            
            title.id = row.Field<int>("id");
            title.name = row.Field<String>("name");
            title.isActive = row.Field<bool>("is_active");

            return title;
        }

        public DataRow mapDataRow(Model model, DataRow rowModel) {
            Title title = (Title) model;

            rowModel["id"] = title.id;
            rowModel["name"] = title.name;
            rowModel["is_active"] = title.isActive;

            return rowModel;
        }
    }
}
