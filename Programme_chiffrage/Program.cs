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
            int iValeurNombre;
            int iConvertionCle;
            string strValeurNombre;
            string strLettre1;
            string strLettre2;
            string strLettre3;
            string strConvertionCle;
            char cValeurNombre;

            do
            {
                strValeurNombre = strCle.Substring(iPosChar, 1);
                cValeurNombre = Convert.ToChar(strValeurNombre);
                iValeurNombre = Convert.ToInt32(cValeurNombre);
                switch (iPosChar)
                {
                    case 0:
                        iLettre1 = iValeurNombre;
                        iPosChar++;
                        break;

                    case 1:
                        iLettre2 = iValeurNombre;
                        iPosChar++;
                        break;

                    case 2:
                        iLettre3 = iValeurNombre;
                        iPosChar++;
                        break;
                }
            }
            while (iPosChar == strCle.Length);

            strLettre1 = Convert.ToString(iLettre1);
            strLettre2 = Convert.ToString(iLettre2);
            strLettre3 = Convert.ToString(iLettre3);

            strConvertionCle = strLettre1 + strLettre2 + strLettre3;

            iConvertionCle = Convert.ToInt32(strConvertionCle);

            return (0);
        }
 
    }
}
