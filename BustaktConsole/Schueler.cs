using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BustaktConsole
{
    class Schueler
    {
        static int Countid = 0;
        static bool switcher = true; //true is schnell(3min) false is langsam(7min)
        public int id { get; private set; }
        public int gehzeit { get; set; }
        public Schueler()
        {
            id = Countid;
            Countid++;
            if (switcher)
            {
                switcher = false;
                gehzeit = 3;
            }
            else
            {
                switcher = true;
                gehzeit = 7;
            }
        }
    }
}
