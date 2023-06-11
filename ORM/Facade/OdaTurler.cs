using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class OdaTurler : IORM<OdaTur>
    {
        bool IORM<OdaTur>.Delete(OdaTur entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<OdaTur>.Insert(OdaTur entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<OdaTur>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<OdaTur>.Update(OdaTur entity)
        {
            throw new NotImplementedException();
        }
    }
}
