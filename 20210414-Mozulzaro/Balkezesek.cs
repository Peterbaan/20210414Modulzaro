using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210414_Mozulzaro
{
    class Balkezesek
    {

        public string név { get; set; }
        public int első { get; set; }
        public int utolsó { get; set; }
        public int súly { get; set; }
        public int magasság { get; set; }

        public Balkezesek(string sor)
        {
            string[] s = sor.Split(';');
            név = (s[0]);
            első = int.Parse(s[1]);
            utolsó = int.Parse(s[2]);
            súly = int.Parse(s[3]);
            magasság = int.Parse(s[4]);

        }

        public static int Count { get; internal set; }
    }
}
