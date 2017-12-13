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

            Console.WriteLine("Voulez-vous [C]hiffrer ou [D]échiffrer ? ");
            cDebutProgramme = Console.ReadKey().KeyChar;

            if (cDebutProgramme == 'c')
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

        static long ConvertionLC(string strMessage)
        {
            
        }

        static long ConvertionCle(string strCle)
        {

        }

        static long ConvertionCL()
        {

        }
 
    }
}
