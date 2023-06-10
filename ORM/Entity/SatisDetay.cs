using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class SatisDetay
    {
        public int SatisId { get; set; }
        public int PersonelId { get; set; }
        public int KasaId { get; set; }
        public int BirimFiyat { get; set; }
        public int Indirim { get; set; }
        public int Miktar { get; set; }

    }
}
