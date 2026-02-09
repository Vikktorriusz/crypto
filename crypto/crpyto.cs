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

        public crypto(string Nev, double Ar, double Ora, double Nap, double Het, double Ev)
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

        public static void torles(List<crypto> cryptoLista)
        {
                
                int sorszam = 0;

                Console.Write("Törlendő index: ");
                int torol;
                int.TryParse(Console.ReadLine() ?? "-1", out torol);

                if (torol >= 0 && torol < cryptoLista.Count)
                    cryptoLista.RemoveAt(torol);
                else {
                    Console.WriteLine("Hibás index!");
                }
            foreach (var z in cryptoLista)
                Console.WriteLine($"{sorszam++}. {z}");
            return;
        } 
    }
}
