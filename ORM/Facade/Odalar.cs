using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Odalar: IORM<Odalar>
    {
        bool IORM<Odalar>.Delete(Odalar entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Odalar>.Insert(Odalar entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Odalar>.Select()
        {
            return Tools.Select("Odalar");
        }

        bool IORM<Odalar>.Update(Odalar entity)
        {
            throw new NotImplementedException();
        }
    }
}
