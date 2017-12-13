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
            string strSerie;
            string strCle;
            long lChiffreSol;
            long lSerie;

            Console.Clear();

            Console.WriteLine("Entrez votre série à déchiffrer : ");
            strSerie = Console.ReadLine();
            lSerie = Convert.ToInt64(strSerie);

            Console.WriteLine("Entrez votre clé de décryptage : ");
            strCle = Console.ReadLine();

            long lCleSol = ConvertionCle(strCle);

            lChiffreSol = lSerie + lCleSol;

            string strMessageSol = ConvertionCL(lChiffreSol);

            Console.WriteLine("Voici votre message décodé : {0} ", strMessageSol);
            Console.ReadKey();

        }

        static long ConvertionLC(string strMessage)
        {
            
        }

        static long ConvertionCle(string strCle)
        {

        }

        static long ConvertionCL(long lChiffreSol)
        {
            string strChiffreSol;
            int iPosChar;

            strChiffreSol = Convert.ToString(lChiffreSol);

            if (strChiffreSol.Length % 3 == 2)
            {
                iPosChar = strChiffreSol.Length - 2;

                int iSwitch = iPosChar;

                for (;;)

            }

            return 0;
        }
 
    }
}
