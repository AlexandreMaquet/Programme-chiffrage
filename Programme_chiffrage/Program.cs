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
            string strMessage;
            string strCle;
            long lChiffreSol;

            Console.Clear();

            Console.WriteLine("Entrez votre message à chiffrer : ");
            strMessage = Console.ReadLine();

            Console.WriteLine("Entrez votre clé de cryptage : ");
            strCle = Console.ReadLine();

            long lMessageSol=ConvertionLC(strMessage);
            long lCleSol=ConvertionCle(strCle);

            lChiffreSol = lMessageSol + lCleSol;
            Console.WriteLine("Voici votre message codé : {0} ", lChiffreSol);
            Console.ReadKey();
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
            int iPosChar = 0;
            long lValeurNombre;
            long lConvertionMessage;
            string strValeurNombre;
            string strConvertionMessage = "";
            string strTempVal;
            char cValeurNombre;

            for (iPosChar = 0; iPosChar < strMessage.Length; iPosChar++)
            {
                strValeurNombre = strMessage.Substring(iPosChar, 1);
                cValeurNombre = Convert.ToChar(strValeurNombre);
                lValeurNombre = Convert.ToInt64(cValeurNombre);
                strTempVal = Convert.ToString(lValeurNombre);
                strConvertionMessage = strConvertionMessage + "0" + strTempVal;

            }

           lConvertionMessage = Convert.ToInt64(strConvertionMessage);

            return lConvertionMessage;
        }

        static long ConvertionCle(string strCle)
        {
            int iPosChar = 0;
            long iValeurNombre;
            long iConvertionCle;
            string strValeurNombre;
            string strConvertionMessage = "";
            string strTempVal;
            char cValeurNombre;

            for (iPosChar = 0; iPosChar < strCle.Length; iPosChar++)
            {
                strValeurNombre = strCle.Substring(iPosChar, 1);
                cValeurNombre = Convert.ToChar(strValeurNombre);
                iValeurNombre = Convert.ToInt64(cValeurNombre);
                strTempVal = Convert.ToString(iValeurNombre);
                strConvertionMessage = strConvertionMessage + "0" + strTempVal;
            }
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
