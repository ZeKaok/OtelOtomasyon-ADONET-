using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ORM.Entity;
using System.Data;

namespace ORM.Facade
{
    internal class Kategoriler: IORM<Kategori>
    {
        bool IORM<Kategori>.Delete(Kategori entity)
        {
            throw new NotImplementedException();
        }

        bool IORM<Kategori>.Insert(Kategori entity)
        {
            throw new NotImplementedException();
        }

        DataTable IORM<Kategori>.Select()
        {
            throw new NotImplementedException();
        }

        bool IORM<Kategori>.Update(Kategori entity)
        {
            throw new NotImplementedException();
        }
    }
}
