using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Kategori
    {
        public int KategorilerId { get; set; }
        public string Ad { get; set; }
        public string Tanim { get; set; }
        public byte Resim { get; set; }
    }
}
