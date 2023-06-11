using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ORMBase<T> : IORM<T>
    {
        bool IORM<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<T>.Insert(T entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<T>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
