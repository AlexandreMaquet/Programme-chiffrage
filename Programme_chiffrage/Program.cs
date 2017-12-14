using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  ____________________________________________
// |  Auteur: Alexandre Maquet                  |
// |  Date: 14.12.2017                          |
// |  Classe: 1M4I1C                            |
// |  Version du logiciel: Visual Studio 15.5.1 |
// |  OS: Windows 10 Pro                        |
// |  Language: C#                              |
// |                                            |
// |  But: Créer un programme de chiffrage      |
// |____________________________________________|

namespace Programme_chiffrage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "___________________________________________________________");
            Console.WriteLine(@" _____                                                     ");
            Console.WriteLine(@" |  __ \                                                   ");
            Console.WriteLine(@" | |__) | __ ___   __ _ _ __ __ _ _ __ ___  _ __ ___   ___ ");
            Console.WriteLine(@" |  ___/ '__/ _ \ / _` | '__/ _` | '_ ` _ \| '_ ` _ \ / _ \");
            Console.WriteLine(@" | | | | | | (_) | (_| | | | (_| | | | | | | | | | | |  __/");
            Console.WriteLine(@" |_|_| |_|__\___/ \__, |_|  \__,_|_| |_| |_|_| |_| |_|\___|");
            Console.WriteLine(@"  / _` |/ _ \      __/ |                                    ");
            Console.WriteLine(@" | (_| |  __/     |___/                                     ");
            Console.WriteLine(@"  \__,_|\___|                                               ");
            Console.WriteLine(@"  _____ _     _  __  __                                    ");
            Console.WriteLine(@" / ____| |   (_)/ _|/ _|                                   ");
            Console.WriteLine(@" | |    | |__  _| |_| |_ _ __ __ _  __ _  ___              ");
            Console.WriteLine(@" | |    | '_ \| |  _|  _| '__/ _` |/ _` |/ _ \             ");
            Console.WriteLine(@" | |____| | | | | | | | | | | (_| | (_| |  __/             ");
            Console.WriteLine(@"  \_____|_| |_|_|_| |_| |_|  \__,_|\__, |\___|             ");
            Console.WriteLine(@"                                    __/ |                  ");
            Console.WriteLine(@"                                   |___/                   ");
            Console.WriteLine( "___________________________________________________________");
            Console.WriteLine("\nBienvenue");
            Console.WriteLine("\nPour continuer pressez une touche");
            Console.WriteLine("___________________________________________________________");
            Console.ReadKey();
            start();


        }

        static void start()
        {
            for (int i = 1; i > 0; i++)
            {
                Console.Clear();

                char cDebutProgramme;

                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("\nQue voulez-vous faire ?");
                Console.WriteLine("\n[c]hiffrer");
                Console.WriteLine("\n[d]échiffrer");
                Console.WriteLine("\n[q]uitter le programme");
                Console.WriteLine("___________________________________________________________");
                cDebutProgramme = Console.ReadKey().KeyChar;

                switch (cDebutProgramme)
                {
                    case 'c':
                        chiffrer();
                        break;
                    case 'd':
                        dechiffrer();
                        break;
                    case 'q':
                        Environment.Exit(0);
                        break;
                }                
            }
        }

        static void chiffrer()
        {
            string strMessage;
            string strCle;
            long lChiffreSol;

            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nEntrez votre message à chiffrer : ");
            Console.WriteLine("___________________________________________________________");
            strMessage = Console.ReadLine();
            while (strMessage.Length > 6)
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("\nVeuillez entrer un mot de moins de 7 caractères");
                Console.WriteLine("___________________________________________________________");
                strMessage = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nEntrez votre clé de cryptage : ");
            Console.WriteLine("___________________________________________________________");
            strCle = Console.ReadLine();
            while (strCle.Length > 6)
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("\nVeuillez entrer un mot de moins de 7 caractères");
                Console.WriteLine("___________________________________________________________");
                strCle = Console.ReadLine();
            }

            long lMessageSol = ConvertionLC(strMessage);
            long lCleSol = ConvertionCle(strCle);

            lChiffreSol = lMessageSol + lCleSol;

            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nVoici votre message codé :");
            Console.WriteLine("\n{0}", lChiffreSol);
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Pour revenir à la séléction, appuyez sur une touche");
            Console.ReadKey();
            start();
        }
        


        static void dechiffrer()
        {
            string strSerie;
            string strCle;
            string strChiffreSol;
            long lSerie;
            long lChiffreSol;

            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nEntrez votre série à déchiffrer : ");
            Console.WriteLine("___________________________________________________________");

            strSerie = Console.ReadLine();
            lSerie = Convert.ToInt64(strSerie);

            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nEntrez votre clé de décryptage : ");
            Console.WriteLine("___________________________________________________________");

            strCle = Console.ReadLine();
            while (strCle.Length > 6)
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("\nVeuillez entrer un mot de moins de 7 caractères");
                Console.WriteLine("___________________________________________________________");
                strCle = Console.ReadLine();
            }

            long lCleSol = ConvertionCle(strCle);

            lChiffreSol = lSerie - lCleSol;
            strChiffreSol = Convert.ToString(lChiffreSol);

            string strMessageSol = ConvertionCL(strChiffreSol);

            Console.Clear();
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("\nVoici votre message décodé :");
            Console.WriteLine("{0}", strMessageSol);
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Pour revenir à la séléction, appuyez sur une touche");
            Console.ReadKey();
            start();

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
                lValeurNombre = lValeurNombre + 3;
                strTempVal = Convert.ToString(lValeurNombre);
                strConvertionMessage = strConvertionMessage + strTempVal;
                
            }

            lConvertionMessage = Convert.ToInt64(strConvertionMessage);

            return lConvertionMessage;


        }

        static long ConvertionCle(string strCle)
        {
            int iPosChar = 0;
            long lValeurNombre;
            long lConvertionCle;
            string strValeurNombre;
            string strConvertionMessage = "";
            string strTempVal;
            char cValeurNombre;

            for (iPosChar = 0; iPosChar < strCle.Length; iPosChar++)
            {
                strValeurNombre = strCle.Substring(iPosChar, 1);
                                    
                cValeurNombre = Convert.ToChar(strValeurNombre);
                lValeurNombre = Convert.ToInt64(cValeurNombre);
                lValeurNombre = lValeurNombre + 3;
                strTempVal = Convert.ToString(lValeurNombre);
                strConvertionMessage = strConvertionMessage + strTempVal;
                 
            }

            lConvertionCle = Convert.ToInt64(strConvertionMessage);

            return lConvertionCle;
        }
       
        static string ConvertionCL(string strChiffreSol)
        {
            string strValeurLettre;
            string strLettre;
            string strMessageSol = "";
            int iPosChar;
            long lValeurLettre;
            char cLettre;
                         
            iPosChar = 0;
            for (int iRepetition = 0; iRepetition < strChiffreSol.Length / 3; iRepetition++)
            {
                 strValeurLettre = strChiffreSol.Substring(iPosChar, 3);
                 lValeurLettre = Convert.ToInt64(strValeurLettre);
                 lValeurLettre = lValeurLettre - 3;
                 cLettre = (char)lValeurLettre;
                 strLettre = Convert.ToString(cLettre);
                 strMessageSol = strMessageSol + strLettre;
                 iPosChar = iPosChar + 3;
            }
            

            return strMessageSol;
        }
    }
}
