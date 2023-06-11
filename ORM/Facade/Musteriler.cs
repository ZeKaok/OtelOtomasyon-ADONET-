using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Musteriler : IORM<Musteri>
    {
        bool IORM<Musteri>.Delete(Musteri entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Musteri>.Insert(Musteri entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Musteri>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<Musteri>.Update(Musteri entity)
        {
            throw new NotImplementedException();
        }
    }
}
