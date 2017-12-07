using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_chiffrage
{
    class Program
    {
        static void Main(string[] args)
        {
            char cDebutProgramme;

            Console.Write("Voulez-vous [C]hiffrer ou [D]échiffrer ? ");
            cDebutProgramme = Console.ReadKey().KeyChar;

            if (cDebutProgramme == 'C')
            {
                chiffrer();
            }
            else
            {
                dechiffrer();
            }
        }

        static void chiffrer()
        {

        }

        static void dechiffrer()
        {

        }
    }
}
