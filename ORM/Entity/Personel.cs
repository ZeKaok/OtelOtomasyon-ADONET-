using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Personel
    {
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public DateTime İseBaslamaTarihi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TcNo { get; set; }
        public string TelNo { get; set; }
        public string Sehir { get; set; }
    }
}
