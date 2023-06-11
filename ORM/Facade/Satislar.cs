using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Satislar : IORM<Satislar>
    {
        bool IORM<Satislar>.Delete(Satislar entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Satislar>.Insert(Satislar entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Satislar>.Select()
        {
            return Tools.Select("Satislar");
        }

        bool IORM<Satislar>.Update(Satislar entity)
        {
            throw new NotImplementedException();
        }
    }
}
