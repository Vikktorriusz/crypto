using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto
{
    public class crypto
    {
        public string nev { get; set; }
        public double ar { get; set; }

        public double ora { get; set; }

        public double nap { get; set; }

        public double het { get; set; }
        public double ev { get; set; }

        public Cryptok(string Nev, double Ar, double Ora, double Nap, double Het, double Ev)
        {
            nev = Nev;
            ar = Ar;
            ora = Ora;
            nap = Nap;
            het = Het;
            ev = Ev;
        }

        public override string ToString()
        {
            return $"{nev} {ar} {ora} {nap} {het} {ev}";
        }


    }
}
