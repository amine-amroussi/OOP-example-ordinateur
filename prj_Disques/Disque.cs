using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_Disques
{
   public class Disque
    {
       //Les Attributs
          //les Attributs d'objet
             public  double Rayon;
          //Les Attributs de Classe
             public static   double PI;


       //Les Méthodes
          //les Méthodes d'objet
             public double Surface()
             {
                 double s = PI * Rayon * Rayon;
                 return s;
             }
             public double Perimetre()
             {
                 double p = 2 * PI * Rayon;
                 return p;
             }
             public void Afficher()
             {
                 double su = Surface();
                 double pe=Perimetre();
                 Console.WriteLine("------------------------------");
                 Console.WriteLine("Rayon du Disque :{0}", Rayon);
                 Console.WriteLine("Surface du Disque :{0}", su);
                 Console.WriteLine("Périmètre du Disque :{0}",pe);
                 Console.WriteLine("------------------------------");
             }
        //Les Méthodes de Classe


       //Les Constructeurs
       public Disque()//Par Défaut
       {       
       }
       public Disque(double ray)//Initialisation
       {
           Rayon = ray;
       }
    }
}
