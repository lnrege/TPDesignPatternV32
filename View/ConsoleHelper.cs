using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class ConsoleHelper
    {
        public static int GetIdEmploye()
        {
            int id = ConsoleHelper.GetInputIntUser("Entrer ID :");
            return id;
        }

        public static string GetNomEmploye()
        {
            string nom = ConsoleHelper.GetInputUser("Entrer Nom :");
            return nom;
        }

        public static string GetPrenomEmploye()
        {
            string prenom = ConsoleHelper.GetInputUser("Entrer Prénom :");
            return prenom;
        }
       public static int GetSalaireEmploye()
        {
            int salaire = ConsoleHelper.GetInputIntUser("Entrer salaire supérieur à 0 :");
            return salaire;
        }

        //méthode permettant de récupérer un entier saisi par l'utilisateur
        public static int GetInputIntUser(string question)
        {
            string input = GetInputUser(question);
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("error retry");
                input = GetInputUser(question);
            }
            return result;
        }



        //méthode permettant de récupérer un string saisi par l'utilisateur
        public static string GetInputUser(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error retry ! ");
                input = Console.ReadLine();
            }
            return input;

        }

        public static void LancerMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 - Ajouter un employé");
            Console.WriteLine("2 - Afficher la liste des employés");
            Console.WriteLine("3 - Afficher un employé en rentrant son ID");
            Console.WriteLine("------------------------------------");
        }
    }
}
