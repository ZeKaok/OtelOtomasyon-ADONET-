using ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facade
{
    internal class Ozellikler : IORM<Ozellik>
    {
        bool IORM<Ozellik>.Delete(Ozellik entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Ozellik>.Insert(Ozellik entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Ozellik>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<Ozellik>.Update(Ozellik entity)
        {
            throw new NotImplementedException();
        }
    }
}
