using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ORM.Entity;

namespace ORM.Facade
{
    internal class Kategoriler:DbContext
    {

        public DbSet<Kategori> Kategoris
        { get; set; }


        
    }
}
