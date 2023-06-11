using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Personeller : IORM<Personel>
    {
        bool IORM<Personel>.Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Personel>.Insert(Personel entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Personel>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<Personel>.Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
