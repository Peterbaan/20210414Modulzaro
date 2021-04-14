﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210414_Mozulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] sorok = File.ReadAllLines("balkezesek.csv");
            List<Balkezesek> balkezes = new List<Balkezesek>();
            foreach (string sor in sorok.Skip(1))
            {
                balkezes.Add(new Balkezesek());
            }
            int N = balkezes.Count;
            Console.WriteLine($"1. Feladat: {N} veresenyző van");  //1. Feladat

            int első = Balkezesek.első;
            int[] Elso = első;
            int Db1980Felett;
            for (i = 0; i < N; i++) { if (Balkezesek.első == 1980) { Db1980Felett++; } }
            Console.WriteLine($"2. Feladat: {Db1980Felett} veresenyző lépett 1980-ban pályára először");


            Console.WriteLine("Adjon meg egy évszámot 1900 és 1999 között!");  //4. Feladat
            int Bekeres = int.Parse(Console.ReadLine());
            if (!(1900 <= Bekeres && Bekeres <= 1999))
            { }
            else 
            { Console.WriteLine("Hibás adat, adja meg újra!"); }


            int minIndex = 0;   //5.Feladat
            for (i = 1; i < N; i++)
            {
                if (Elso[i] < Elso[minIndex]) { minIndex = i; }

            }
            i = 0;              //6.Feladat
            while (i < N && !(Elso[i] % 2 == 0))
            {
                i++;
            }
            bool van = i < N;

            int JohnDB = 0;         //7.Feladat
            for (i = 0; i < N; i++) { if (Balkezesek.név[i] == "John") { JohnDB++; } }



            Console.ReadLine();
        }
    }
}
