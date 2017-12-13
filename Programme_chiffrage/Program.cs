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
            string strChiffreSol;
            long lSerie;
            long lChiffreSol;

            Console.Clear();

            Console.WriteLine("Entrez votre série à déchiffrer : ");
            strSerie = Console.ReadLine();
            lSerie = Convert.ToInt64(strSerie);

            Console.WriteLine("Entrez votre clé de décryptage : ");
            strCle = Console.ReadLine();

            long lCleSol = ConvertionCle(strCle);

            lChiffreSol = lSerie + lCleSol;
            strChiffreSol = Convert.ToString(lChiffreSol);

        static void dechiffrer()
        {
            string strSerie;
            string strCle;
            string strChiffreSol;
            long lSerie;
            long lChiffreSol;

            Console.Clear();

            Console.WriteLine("Entrez votre série à déchiffrer : ");
            strSerie = Console.ReadLine();
            lSerie = Convert.ToInt64(strSerie);

            Console.WriteLine("Entrez votre clé de décryptage : ");
            strCle = Console.ReadLine();

            long lCleSol = ConvertionCle(strCle);

            lChiffreSol = lSerie + lCleSol;
            strChiffreSol = Convert.ToString(lChiffreSol);

            string strMessageSol = ConvertionCL(strChiffreSol);

            Console.WriteLine("Voici votre message décodé : {0} ", strMessageSol);
            Console.ReadKey();

        }

        static long ConvertionLC(string strMessage)
        {

        }

        static long ConvertionCle(string strCle)
        {

        }

        static string ConvertionCL(string strChiffreSol)
        {
            string strValeurLettre;
            string strLettre;
            string strMessageSol = "";
            int iPosChar;
            long lValeurLettre;
            char cLettre;


            if (strChiffreSol.Length % 3 == 2)
            {
                strValeurNombre = strCle.Substring(iPosChar, 1);
                cValeurNombre = Convert.ToChar(strValeurNombre);
                iValeurNombre = Convert.ToInt64(cValeurNombre);
                strTempVal = Convert.ToString(iValeurNombre);
                strConvertionMessage = strConvertionMessage + "0" + strTempVal;
            }

            // TODO: À supprimer
            return 0;
        }

        static string ConvertionCL(string strChiffreSol)
        {
            string strValeurLettre;
            string strLettre;
            string strMessageSol = "";
            int iPosChar;
            long lValeurLettre;
            char cLettre;


            if (strChiffreSol.Length % 3 == 2)
            {
                iPosChar = strChiffreSol.Length - 2;

                int iSwitch = iPosChar;

                for (int iRepetition = 0; iRepetition < strChiffreSol.Length / 3 - 1; iRepetition++)
                {
                    strValeurLettre = strChiffreSol.Substring(iPosChar, 3);
                    lValeurLettre = Convert.ToInt64(strValeurLettre);
                    cLettre = (char)lValeurLettre;
                    strLettre = Convert.ToString(cLettre);
                    strMessageSol = strLettre + strMessageSol;
                    iPosChar = iPosChar - 3;
                }

            }

            else
            {
                iPosChar = 0;
                for (int iRepetition = 0; iRepetition < strChiffreSol.Length / 3; iRepetition++)
                {
                    strValeurLettre = strChiffreSol.Substring(iPosChar, 3);
                    lValeurLettre = Convert.ToInt64(strValeurLettre);
                    cLettre = (char)lValeurLettre;
                    strLettre = Convert.ToString(cLettre);
                    strMessageSol = strLettre + strMessageSol;
                    iPosChar = iPosChar - 3;
                }
            }

            return strMessageSol;
        }
    }
}
