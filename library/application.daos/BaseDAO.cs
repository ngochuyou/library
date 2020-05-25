using library.application.models;
using library.application.models.mapping;
using library.application.service.services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace library.application.daos {
    class BaseDAO {

        protected SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString);
        
        protected DataSet database = new DataSet("database");

        protected int maxResults = 100;

        protected Dictionary<Type, string> modelMap;

        protected Dictionary<Type, CommandProvider> commandProviders;

        public BaseDAO() {
            modelMap = new Dictionary<Type, string>();
            modelMap.Add(typeof(Employee), "employees");
            modelMap.Add(typeof(Title), "titles");
            modelMap.Add(typeof(Customer), "customers");
            modelMap.Add(typeof(Book), "books");
            modelMap.Add(typeof(PaymentReceipt), "payment_receipts");
            modelMap.Add(typeof(LendingReceipt), "lending_receipts");
            modelMap.Add(typeof(LendingReceiptDetail), "lending_receipt_details");

            commandProviders = new Dictionary<Type, CommandProvider>();
            commandProviders.Add(typeof(Employee), new EmployeeCommandProvider());
            commandProviders.Add(typeof(Title), new TitleCommandProvider());
            commandProviders.Add(typeof(Customer), new CustomerCommandProvider());
            commandProviders.Add(typeof(Book), new BookCommandProvider());
            commandProviders.Add(typeof(PaymentReceipt), new PaymentReceiptCommandProvider());
            commandProviders.Add(typeof(LendingReceipt), new LendingReceiptCommandProvider());
            commandProviders.Add(typeof(LendingReceiptDetail), new LendingReceiptDetailCommandProvider());

            foreach(Type key in modelMap.Keys) {
                new SqlDataAdapter($"SELECT * FROM {modelMap[key]}", connection)
                        .Fill(database, modelMap[key]);

                DataTable table = database.Tables[modelMap[key]];

                table.PrimaryKey = new DataColumn[] { table.Columns["id"] };
            }
        }

        public DataTable getDataTable(Type clazz) {

            return database.Tables[modelMap[clazz]];
        }

        public List<T> getList<T>(Type clazz) {
            CommandProvider commandProvider;

            try {
                commandProvider = commandProviders[clazz];
            } catch (Exception e) {
                Console.WriteLine("BaseDAO" + e.Message);
                return new List<T>();
            }

            return database.Tables[modelMap[clazz]]
                    .AsEnumerable()
                    .Select(row => commandProvider.mapModel(row))
                    .Where(model => model.isActive == true)
                    .OfType<T>().ToList();
        }

        public List<T> getlist<T>(Type clazz, int page, int amount) {
            CommandProvider commandProvider;

            try {
                commandProvider = commandProviders[clazz];
            } catch (Exception e) {
                Console.WriteLine("BaseDAO" + e.Message);
                return new List<T>();
            }

            return database.Tables[modelMap[clazz]]
                    .AsEnumerable()
                    .Skip((page - 1) * amount).Take(amount)
                    .Select(row => commandProvider.mapModel(row))
                    .Where(model => model.isActive == true)
                    .OfType<T>().ToList();
        }

        public DatabaseOperationResult insert(Model entity, Type clazz) {
            CommandProvider commandProvider;

            try {
                commandProvider = commandProviders[clazz];
            } catch (Exception) {
                return new DatabaseOperationResult(ServiceStatus.FAILED, "No CommandProvider found. Try to provide implicit CommandProvider.");
            }

            DataTable table = database.Tables[modelMap[clazz]];

            entity.setId(commandProvider.generatePrimaryKey(entity, table, connection));

            SqlCommand insertCommand = commandProvider.createInsertCommand(entity, modelMap[clazz], connection);

            try {
                insertCommand.Connection.Open();
                insertCommand.Transaction = insertCommand.Connection.BeginTransaction();
                insertCommand.ExecuteNonQuery();
                insertCommand.Transaction.Commit();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                insertCommand.Transaction.Rollback();

                return new DatabaseOperationResult(ServiceStatus.FAILED, e.Message);
            } finally {
                insertCommand.Connection.Close();
            }

            table.Rows.Add(commandProvider.mapDataRow(entity, table.NewRow()));

            return new DatabaseOperationResult(ServiceStatus.OK, "OK");
        }

        public DatabaseOperationResult delete(Model entity, Type clazz) {
            CommandProvider commandProvider;

            try {
                commandProvider = commandProviders[clazz];
            } catch (Exception) {
                return new DatabaseOperationResult(ServiceStatus.FAILED, "No CommandProvider found. Try to provide implicit CommandProvider.");
            }

            SqlCommand deleteCommand = commandProviders[clazz].createDeleteCommand(entity, modelMap[clazz], connection);
            
            try {
                deleteCommand.Connection.Open();
                deleteCommand.ExecuteNonQuery();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return new DatabaseOperationResult(ServiceStatus.FAILED, e.Message);
            } finally {
                deleteCommand.Connection.Close();
            }

            database.Tables[modelMap[clazz]].Rows.Find(entity.getId())["is_active"] = false;

            return new DatabaseOperationResult(ServiceStatus.OK, "OK");
        }

        public DatabaseOperationResult update(Model entity, Type clazz) {
            CommandProvider commandProvider;

            try {
                commandProvider = commandProviders[clazz];
            } catch (Exception) {
                return new DatabaseOperationResult(ServiceStatus.FAILED, "No CommandProvider found. Try to provide implicit CommandProvider.");
            }

            SqlCommand updateCommand = commandProviders[clazz].createUpdateCommand(entity, modelMap[clazz], connection);
            
            try {
                updateCommand.Connection.Open();
                updateCommand.ExecuteNonQuery();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return new DatabaseOperationResult(ServiceStatus.FAILED, e.Message);
            } finally {
                updateCommand.Connection.Close();
            }

            DataTable table = database.Tables[modelMap[clazz]];
            DataRow preUpdateRow = table.Rows.Find(entity.getId());
            DataRow postUpdateRow = commandProvider.mapDataRow(entity, table.NewRow());

            foreach(DataColumn columnName in preUpdateRow.Table.Columns) {
                preUpdateRow[columnName] = postUpdateRow[columnName];
            }

            return new DatabaseOperationResult(ServiceStatus.OK, "OK");
        }

        public DataTable getTable(Type clazz) {

            return database.Tables[this.modelMap[clazz]];
        }

        public String getTableName(Type clazz) {

            return this.modelMap[clazz];
        }

        public SqlConnection getConnection() {

            return this.connection;
        }

        public CommandProvider GetCommandProvider(Type clazz) {

            return commandProviders[clazz];
        }
    }
}
