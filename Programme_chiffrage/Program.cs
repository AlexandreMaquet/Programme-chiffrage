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
            string strMessage;
            string strCle;
            int iChiffreSol;
            

            Console.WriteLine("Entrez votre message à chiffrer : ");
            strMessage = Console.ReadLine();

            Console.WriteLine("Entrez votre clé de cryptage : ");
            strCle = Console.ReadLine();
            int iCleSol = ConvertionCle(strCle);

            iChiffreSol = iMessageSol * iCleSol;
            Console.WriteLine("Voici votre message codé : {0} ", iChiffreSol);
            Console.ReadKey();
        }

        static void dechiffrer()
        {

        }

        static int ConvertionLC(string strMessage)
        {
            return 0;
        }

        static int ConvertionCle(string strCle)
        {
            int iPosChar = 0;
            int iLettre1 = 0;
            int iLettre2 = 0;
            int iLettre3 = 0;
            int iValeurNombre = 0;

            do
            {
                 iValeurNombre = strCle.ToCharArray(iPosChar, 1);
            }
            while (iPosChar == strCle.Length);





            return (0);
        }
 
    }
}
