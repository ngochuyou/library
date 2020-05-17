using System;
using System.Data;
using System.Data.SqlClient;

namespace library.application.models.mapping {
    class BookCommandProvider: CommandProvider {

        public Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection) {
            SqlCommand queryCommand = new SqlCommand($"SELECT MAX(id) FROM {table.TableName}", connection);

            queryCommand.Connection.Open();

            object id = queryCommand.ExecuteScalar();
            object key = (id.GetType() == typeof(DBNull) ? 0 : (object) ((int) (queryCommand.ExecuteScalar()) + 1));
            
            queryCommand.Connection.Close();

            return key;
        }

        public SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection) {
            Book book = (Book) model;
            String sql = $"INSERT INTO {tableName} ([id], [name], [author], [publish_date], [publisher], [price], [stocked_date], [is_active]) " +
                "VALUES (@id, @name, @author, @publishDate, @publisher, @price, @stockedDate, @isActive)";
            SqlCommand insertCommand = new SqlCommand(string.Format(sql), connection);

            insertCommand.Parameters.AddWithValue("@id", book.id);
            insertCommand.Parameters.AddWithValue("@name", book.name);
            insertCommand.Parameters.AddWithValue("@author", book.author);
            insertCommand.Parameters.AddWithValue("@publishDate", book.publishDate);
            insertCommand.Parameters.AddWithValue("@publisher", book.publisher);
            insertCommand.Parameters.AddWithValue("@price", book.price);
            insertCommand.Parameters.AddWithValue("@stockedDate", book.stockedDate);
            insertCommand.Parameters.AddWithValue("@isActive", book.isActive);

            return insertCommand;
        }
        public SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection) {
            String sql = $"UPDATE {tableName} SET is_active = 0 WHERE id = @id";
            SqlCommand deleteCommand = new SqlCommand(string.Format(sql), connection);

            deleteCommand.Parameters.AddWithValue("@id", model.getId());

            return deleteCommand;
        }
        public SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection) {
            Book book = (Book) model;
            String sql = $"UPDATE {tableName} SET name = @name, author = @author, publish_date = @publishDate, publisher = @publisher, price = @price, stocked_date = @stockedDate, is_active = @isActive WHERE id = @id";
            SqlCommand updateCommand = new SqlCommand(string.Format(sql), connection);

            updateCommand.Parameters.AddWithValue("@id", book.id);
            updateCommand.Parameters.AddWithValue("@name", book.name);
            updateCommand.Parameters.AddWithValue("@author", book.author);
            updateCommand.Parameters.AddWithValue("@publishDate", book.publishDate);
            updateCommand.Parameters.AddWithValue("@publisher", book.publisher);
            updateCommand.Parameters.AddWithValue("@price", book.price);
            updateCommand.Parameters.AddWithValue("@stockedDate", book.stockedDate);
            updateCommand.Parameters.AddWithValue("@isActive", book.isActive);

            return updateCommand;
        }
        public Model mapModel(DataRow row) {
            Book book = new Book();
            
            if (row == null) {
                return book;
            }
            
            book.id = row.Field<int>("id");
            book.name = row.Field<String>("name");
            book.author = row.Field<String>("author");
            book.publishDate = row.Field<DateTime>("publish_date");
            book.publisher = row.Field<String>("publisher");
            book.price = row.Field<Double>("price");
            book.stockedDate = row.Field<DateTime>("stocked_date");
            book.isActive = row.Field<bool>("is_active");

            return book;
        }

        public DataRow mapDataRow(Model model, DataRow row) {
            Book book = (Book) model;

            row["id"] = book.id;
            row["name"] = book.name;
            row["author"] = book.author;
            row["publish_date"] = book.publishDate;
            row["publisher"] = book.publisher;
            row["price"] = book.price;
            row["stocked_date"] = book.stockedDate;
            row["is_active"] = book.isActive;

            return row;
        }

    }
}
