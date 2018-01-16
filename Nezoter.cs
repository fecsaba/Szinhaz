using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szinhaz
{
    class Nezoter
    {
        // Mezők
        string[,] Foglaltsag;
        int[,] Kategoriak;
        public int OsszesSzek { get; private set; }
        public int FoglaltSzek { get; private set; }
        public int Szazalek { get; private set; }
        public int[] Kat = new int[5];
        public int Bevetel { get; private set; }
        // Jellemzők




        //Konstruktor
        public Nezoter()
        {
            Foglaltsag = new string[17, 20];
            Kategoriak = new int[17, 20];
            string[] f = File.ReadAllLines("f.txt");
            string[] k = File.ReadAllLines("k.txt");
            
            for (int sor = 0; sor < 17; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    Foglaltsag[sor, oszlop] = f[sor].Substring(oszlop, 1);
                    Kategoriak[sor, oszlop] = int.Parse(k[sor].Substring(oszlop, 1));
                }
            }
            //for (int i = 0; i < 17; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        Console.Write(Foglaltsag[i,j]);
            //    }
            //    Console.WriteLine();
            //}
        }

        

        public void Beker() //2.
        {
            Console.Write("Sor: ");
            int sor = int.Parse(Console.ReadLine());
            Console.Write("Szék: ");
            int szek = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(SzabadE(sor-1,szek-1) ? "foglalt" : "szabad")}");
        }
        bool SzabadE(int sor, int szek) //2.
        {
            if (Foglaltsag[sor, szek] == "x") return false;
            else return true;
        }
        public int Eladott()
        {
            for (int sor = 0; sor < Foglaltsag.GetLength(0); sor++)
            {
                for (int szek = 0; szek < Foglaltsag.GetLength(1); szek++)
                {
                    if (Foglaltsag[sor, szek] == "x")
                    {
                        FoglaltSzek++;
                    }
                    OsszesSzek++;
                }
            }
            Szazalek = (int)((double)FoglaltSzek / OsszesSzek * 100);
            return Szazalek;
        }
        public void MaxKat()
        {
            
            for (int sor = 0; sor < Kategoriak.GetLength(0); sor++)
            {
                for (int szek = 0; szek < Kategoriak.GetLength(1); szek++)
                {
                    Kategoria szekKat = new Kategoria(Kategoriak[sor, szek]);
                    Kat[Kategoriak[sor,szek]-1] ++;
                    Bevetel += szekKat.Arkategoria;


                }
            }
        }

    }
}

