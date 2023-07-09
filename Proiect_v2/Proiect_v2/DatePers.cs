using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2
{
    [Serializable]
    public class DatePers
    {
        public string Nume;
        public string Prenume;
        public string CNP;
        public string Numar;
        public string Email;

        public DatePers(string nume, string prenume, string cnp, string nr, string email)
        {
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Numar = nr;
            Email = email;
        }

        public DatePers()
        { }
    }
}
