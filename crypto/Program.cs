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
                Console.WriteLine("2 - Keresés név szerint");
                Console.WriteLine("3 - Legjobb árban lévő crypto");
                Console.WriteLine("4 - Legrosszabb árban lévő Crypto");
                Console.WriteLine("5 - Hogyan kezdj el Cryptozni");

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

                    case "2":
                        Console.Clear();
                        Console.Write("Add meg a keresett kripto nevét: ");
                        string keres = (Console.ReadLine() ?? "").ToLower().Trim();

                        sorszam = 0;
                        foreach (var c in cryptoLista)
                        {
                            if (c.nev.ToLower().Trim() == keres)  
                                Console.WriteLine($"{sorszam++}. {c.nev} - Ár: ${c.ar:F2} | 1ó: {c.ora}% | 1n: {c.nap} % | 1h:  {c.het}% | 1év: {c.ev}%");
                        }
                        Console.WriteLine("\nNyomj meg egy billentyűt a folytatáshoz...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Legrosszabb árban lévő Crypto");

                        crypto legrosszabb = cryptoLista[0];
                        foreach (var c in cryptoLista)
                        {
                            if (c.ar < legrosszabb.ar)
                                legrosszabb = c;
                        }

                        sorszam = 0;
                        Console.WriteLine($"{sorszam++}. {legrosszabb.nev} - Ár: ${legrosszabb.ar:F2} | 1ó: {legrosszabb.ora}% | 1n: {legrosszabb.nap}% | 1h: {legrosszabb.het}% | 1év: {legrosszabb.ev}%");
                        Console.WriteLine("\nNyomj meg egy billentyűt a folytatáshoz...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
