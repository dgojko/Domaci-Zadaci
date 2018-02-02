using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class GodisnjaDoba
    {
        static void Main(string[] args)
        {
            int a;
            bool b = true;

            while (b)
            {
                Console.WriteLine("Unesi broj od 1 do 12 :  ");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Zima");
                        b = false;
                        break;
                    case 2:
                        Console.WriteLine("Zima");
                        b = false;
                        break;
                    case 3:
                        Console.WriteLine("Zima");
                        b = false;
                        break;
                    case 4:
                        Console.WriteLine("Prolece");
                        b = false;
                        break;
                    case 5:
                        Console.WriteLine("Prolece");
                        b = false;
                        break;
                    case 6:
                        Console.WriteLine("Jesen");
                        b = false;
                        break;
                    case 7:
                        Console.WriteLine("Prolece");
                        b = false;
                        break;
                    case 8:
                        Console.WriteLine("Leto");
                        b = false;
                        break;
                    case 9:
                        Console.WriteLine("Leto");
                        b = false;
                        break;
                    case 10:
                        Console.WriteLine("Leto");
                        b = false;
                        break;
                    case 11:
                        Console.WriteLine("Jesen");
                        b = false;
                        break;
                    case 12:
                        Console.WriteLine("Jesen");
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Uneti broj je pogresan. Unesi novi broj od 1 do 12 : ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
