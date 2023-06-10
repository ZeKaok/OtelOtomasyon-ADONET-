using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Kasa
    {
        public int KasaId { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int Aktif { get; set; }
    }
}
