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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - Crypto betöltése és listázása");

                string menu = Console.ReadLine() ?? "";
                int sorszam = 0;

                switch (menu)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Clear();
                        sorszam = 0;
                        foreach (var c in cryptoLista)
                            Console.WriteLine($"{sorszam++}. {c.nev} - Ár: {c.ar:F2} | 1ó: {c.ora}% | 1n: {c.nap}% | 1h: {c.het}% | 1év: {c.ev}%");
                        Console.WriteLine("\nNyomj meg egy billentyűt a folytatáshoz...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
