using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace crypto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<crypto> cryptoLista = new List<crypto>();
            var sorok = File.ReadAllLines("crypto.txt", System.Text.Encoding.Latin1).Skip(1);

            foreach (var sor in sorok)
            {
                string[] adatok = sor.Split(';');
                string Nev = adatok[0];
                double Ar = double.Parse(adatok[1]);
                double Ora = double.Parse(adatok[2]);
                double Nap = double.Parse(adatok[3]);
                double Het = double.Parse(adatok[4]);
                double Ev = double.Parse(adatok[5]);
                crypto osszadat = new crypto(Nev,Ar,Ora,Nap,Het,Ev);
                cryptoLista.Add(osszadat);
            }
            foreach (var item in cryptoLista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
