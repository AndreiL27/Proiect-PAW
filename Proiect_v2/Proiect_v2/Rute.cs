using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_v2
{
    [Serializable]
    public class Rute
    {
        public int nrRez;
        public string AeroportPlecare;
        public string AeroportSosire;
        public DateTime Data;
        public int Distanta;
        public float Pret;

        public Rute(int nr, string plecare, string sosire, DateTime dt, int dist, float pr)
        {
            nrRez = nr;
            AeroportPlecare = plecare;
            AeroportSosire = sosire;
            Data = dt;
            Distanta = dist;
            Pret = pr;
        }

        public Rute() 
        { }
    }
}
