using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BustaktConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahlbus = 0;//Busvoll
            List<Schueler> wartende = new List<Schueler>();
            //Delta T = 1 min
            for (int i = 0; i <= 30; i++)// 0 = 7:30; 30 = 8:00
            {
                int anzahladd = 0;
                switch (i)
                {
                    case 0:
                        anzahladd = 20;
                        break;
                    case 3:
                        anzahladd = 25;
                        break;
                    case 6:
                        anzahladd = 30;
                        break;
                    case 9:
                        anzahladd = 70;
                        break;
                    case 12:
                        anzahladd = 90;
                        break;
                    case 15:
                        anzahladd = 100;
                        break;
                    case 18:
                        anzahladd = 110;
                        break;
                    case 21:
                        anzahladd = 80;
                        break;
                    case 24:
                        anzahladd = 60;
                        break;
                    case 27:
                        anzahladd = 60;
                        break;
                    case 29:
                        anzahladd = 50;
                        break;
                }
                for (int j = 0; j < anzahladd; j++)
                {
                    wartende.Add(new Schueler());
                }
                int tmpcount = 0;
                List<int> tmpbus = new List<int>();
                for (int j = 0; j < wartende.Count; j++)
                {
                    if (wartende[j].gehzeit > 0)
                    {
                        wartende[j].gehzeit--;
                    }
                    if (wartende[j].gehzeit <= 0)
                    {
                        tmpcount++;
                        if (anzahlbus < 90)
                        {
                            anzahlbus++;
                            tmpcount--;
                            tmpbus.Add(i);
                        }
                    }
                }
                //Console.WriteLine($"tempbuscount: {tmpbus.Count}");
                for (int n = 0; n < tmpbus.Count; n++)
                {
                    wartende.RemoveAt(tmpbus[n]);
                    //Console.WriteLine(n + " " + wartende.Count);
                }
                tmpbus = null;
                if (i % 5 == 0)
                {
                    anzahlbus = 0;
                }
                if (i % 10 == 0)
                {
                    if (i == 30)
                    {
                        Console.WriteLine($"8:00 Momentan warten beim 94A: {(anzahlbus + tmpcount) - 90}");
                    }
                    else
                    {
                        if (i < 10)
                        {

                            Console.WriteLine($"7:3{i} Momentan warten beim 94A: {anzahlbus + tmpcount}");
                        }
                        else
                        {
                            Console.WriteLine($"7:{i+30} Momentan warten beim 94A: {anzahlbus + tmpcount}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
