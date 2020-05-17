using library.application.models;
using System;
using System.Data;
using System.Linq;

namespace library.application.daos {
    class TitleDAO: BaseDAO {

        protected Type clazz = typeof(Title);

        public Title findById(int id){
            DataRow data = getDataTable(clazz)
                    .AsEnumerable()
                    .First(row => row.Field<int>("id") == id);

            return (Title) commandProviders[clazz].mapModel(data);
        }

    }
}
