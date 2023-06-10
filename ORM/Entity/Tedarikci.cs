using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entity
{
    internal class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string SirketAdi { get; set; }
        public string SirketNo { get; set; }
        public string Ulke { get; set; }
        public string Bolge { get; set; }
    }
}
