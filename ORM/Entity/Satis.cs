using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Satis
    {
        public int SatisId { get; set; }
        public DateTime SatisTarihi { get; set;}
        public int PersonelId { get; set; }
        public int MusteriId { get; set; }
        public string Bolge { get; set; }
        public int UrunId { get; set; }
        public int OdaId { get; set; }
    }
}
