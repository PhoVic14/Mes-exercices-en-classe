using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes_exercices_en_classe
{
    class Program
    {
        static void Mes_exercices_en_classe(int age, out string categorie)
        {
            if (age >= 12)

                categorie = "Cadet";

            else if (age >= 10)
            {
                categorie = "Minime";
            }else if (age >= 8)
            {
                categorie = "Pupille";

            }
            else if (age >= 6)
            {
                categorie = "poussin";
            }
            else
            {
                categorie = "oh le bébé";
            }
        } 


        static void Main(string[] args)
        {
            int age=0;
            string categorie = "";

             

            Console.WriteLine("Encodez votre age");
            age = int.Parse(Console.ReadLine());

            Mes_exercices_en_classe(age, out categorie);

            Console.WriteLine($"Vous ètes en catégorie : {categorie}");
            Console.ReadLine();
        }
    }
}
