using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class ParniNeparni
    {
        static void Main(string[] args)
        {
            int[] parni = new int[25];
            int i, j;

            /* inicijalizovanje elemenata niza parni*/
            for (i = 0; i <= 24; i++)
            {
                parni[i] = 2 * (i+1);
            }

            /*ispisivanj vrednosti clanova parnog niza*/

            Console.WriteLine("Clanovi parnog niza su : ");

            for (j = 0; j <= 24; j++)
            {
                Console.WriteLine("{0}. clan parnog niza je : {1}", j, parni[j]);
            }

            int[] neparni = new int[26];
            int a, b;

            /* inicijalizovanje elemenata niza parni*/
            for (a = 0; a <= 25; a++)
            {
                neparni[a] = 2 * a + 1;
            }

            /*ispisivanj vrednosti clanova neparnog niza*/
            Console.WriteLine();
            Console.WriteLine("Clanovi neparnog niza su : ");

            for (b = 0; b <= 25; b++)
            {
                Console.WriteLine("{0}. clan neparnog niza je : {1}", b, neparni[b]);
            }

            Console.ReadLine();
        }
    }
}
