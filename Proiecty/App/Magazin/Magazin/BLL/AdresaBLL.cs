using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.BLL
{
    class AdresaBLL
    {
        public int Id_adresa { get; set; }
        public int Id_client { get; set; }
        public string Oras { get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public int Etaj { get; set; }
        public int Apartament { get; set; }
    }
}
