using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Oda
    {
        public int OdaId { get; set; }
        public int OdaTurId { get; set; }
        public string Adi { get; set; }
        public string Aciklama{get; set;}
        public string Aktif { get; set; }
    }
}
