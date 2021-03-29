using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_Disques
{
    class Program
    {
        static void Main(string[] args)
        {
            Disque.PI = 3.14;

            // Siasie le nombre des article 
            Console.Write("Saisie le nombres des articles : ");
            int nbDesArticles = int.Parse(Console.ReadLine());

             // Declaration de tableau
            Disque [] TabDisque = new Disque[nbDesArticles];


            double ray;

            for (int i = 0; i < TabDisque.Length; i++)
            {
                Console.Write("Saisie la valeur de rayon {0} : " , i+1);
                ray = double.Parse(Console.ReadLine());


                TabDisque[i] = new Disque(ray);
            }

            // Afichage 
            for (int i = 0; i < TabDisque.Length; i++)
            {
                TabDisque[i].Afficher();
            }

            Console.ReadKey();
        }
    }
}
