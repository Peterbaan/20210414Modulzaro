using System;
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
            string[] sorok = File.ReadAllLines("balkezesek.csv");
            List<Balkezesek> balkezesek = new List<Balkezesek>();
            foreach (string sor in sorok.Skip(1))
            {
                balkezesek.Add(new Balkezesek());
            }
            int N = balkezesek.Count;
            Console.WriteLine($"1. Feladat: {N} veresenyző van");

            Console.ReadLine();
        }
    }
}
