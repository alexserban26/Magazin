using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.BLL
{
    class ComandaBLL
    {
        public int comanda_id { get; set; }
        public int adresa_id { get; set; }
        public DateTime data_comanda { get; set; }
        public DateTime data_expediere { get; set; }
        public string  stare { get; set; }
    }
}
