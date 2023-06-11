using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Kasalar : IORM<Kasa>
    {
        bool IORM<Kasa>.Delete(Kasa entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Kasa>.Insert(Kasa entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Kasa>.Select()
        {
            return Tools.Select("Kasa");
        }

        bool IORM<Kasa>.Update(Kasa entity)
        {
            throw new NotImplementedException();
        }
    }
}
