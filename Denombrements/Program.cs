using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        ///<summary>
        ///afficher la saisie du total des éléments 
        ///</summary>
        /// 
        static int total()
        {
            Console.Write("nombre total d'éléments à gérer = ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        ///<summary>
        ///afficher le nombres d'éléments séléctionnés
        /// </summary>
        static int selection()
        {
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        /// <summary>
        /// factorielle du nobre total des éléments
        /// </summary>
        /// <param name="nbTotal">nb total des éléments</param>
        /// <returns></returns>
        static long factorielle(int nbTotal)
        {
            // calcul de r                                  
            long factorielle = 1;
            for (int k = 1; k <= nbTotal; k++)
            {
                factorielle *= k;
            }
            return factorielle;
        }
        /// <summary>
        /// factorielle de (n-p)
        /// </summary>
        /// <param name="nbTotal"></param>
        /// <param name="nbSelection"></param>
        /// <returns>r1</returns>
        static long fact(int nbTotal,int nbSelection)
        {
            long r1 = 1;
            for (int k = (nbTotal - nbSelection + 1); k <= nbTotal; k++)
            {
                r1 *= k;
            }
            return r1;
        }
        /// <summary>
        /// proposer des tests sur les permutations, les arrangements et les combinaisons
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                ///proposition du choix en boucle si on n'entre pas 0
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());
                if (choix == 0)
                {
                    Environment.Exit(0);
                }
                if (choix == 1)
                {
                    int nbTotal = total();
                    Console.WriteLine(nbTotal + "! = " + factorielle(nbTotal));
                }
                if (choix == 2)
                {
                    int nbTotal = total();
                    int nbSelection = selection();
                    // calcul de r
                    long r =fact( nbTotal, nbSelection);
                    Console.WriteLine("A(" + nbTotal + "/" + nbSelection + ") = " + (factorielle(nbTotal)/r));   
                }
                if (choix==3)
                {
                    int nbTotal = total();
                    int nbSelection = selection();
                    // calcul de r1
                    long r1 = fact(nbTotal,nbSelection);
                    // calcul de r2
                    long r2 = 1;
                    for (int k = 1; k <= nbSelection; k++)
                    {
                        r2 *= k;
                    }
                    Console.WriteLine("C(" + nbTotal + "/" + nbSelection + ") = " + ((factorielle(nbTotal))/(r1 / r2)));
                }
            }
            Console.ReadLine();
        }
    }
}
