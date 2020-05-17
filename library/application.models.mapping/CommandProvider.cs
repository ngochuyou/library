using System;
using System.Data;
using System.Data.SqlClient;

namespace library.application.models.mapping {

    interface CommandProvider {

        Object generatePrimaryKey(Model model, DataTable table, SqlConnection connection);

        SqlCommand createInsertCommand(Model model, String tableName, SqlConnection connection);

        SqlCommand createDeleteCommand(Model model, String tableName, SqlConnection connection);

        SqlCommand createUpdateCommand(Model model, String tableName, SqlConnection connection);

        Model mapModel(DataRow row);

        DataRow mapDataRow(Model model, DataRow rowModel);

    }

}
