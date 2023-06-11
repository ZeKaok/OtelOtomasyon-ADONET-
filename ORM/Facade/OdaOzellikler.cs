using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class OdaOzellikler : IORM<OdaOzellik>
    {
        public bool Delete(OdaOzellik entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(OdaOzellik entity)
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {
            return Tools.Select("OdaOzellikleri");
        }

        public bool Update(OdaOzellik entity)
        {
            throw new NotImplementedException();
        }
    }
}
