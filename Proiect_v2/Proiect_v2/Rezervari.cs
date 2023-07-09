using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2
{
    [Serializable]
    public class Rezervari
    {
        public List<Rute> ListaRute;
        public List<DatePers> ListaDatePers;

        public Rezervari()
        {
            ListaRute = new List<Rute>();
            ListaDatePers = new List<DatePers>();
        }
    }
}
