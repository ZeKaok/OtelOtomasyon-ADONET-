using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Tedarikciler : IORM<Tedarikci>
    {
        bool IORM<Tedarikci>.Delete(Tedarikci entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Tedarikci>.Insert(Tedarikci entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Tedarikci>.Select()
        {
            return Tools.Select("Tedarikciler");
        }

        bool IORM<Tedarikci>.Update(Tedarikci entity)
        {
            throw new NotImplementedException();
        }
    }
}
