using Entities;
using Controller;
using Repository;
using View;
using Unity;
using Repository.Contracts;
using Business;
using Business.Contracts;


int choix = 18;

IUnityContainer unitycontainer = new UnityContainer();
unitycontainer.RegisterType<IEmployeRepository, EmployeRepository>();
unitycontainer.RegisterType<IEmployeBusiness, EmployeBusiness>();
EmployeController monController = unitycontainer.Resolve<EmployeController>();

void AjouterEmploye()
{
    monController.AjouterEmploye(ConsoleHelper.GetIdEmploye(), ConsoleHelper.GetNomEmploye(), ConsoleHelper.GetPrenomEmploye(), ConsoleHelper.GetSalaireEmploye());
}

while (choix != 0)
{
    ConsoleHelper.LancerMenu();

    choix = ConsoleHelper.GetInputIntUser("Que souhaitez vous faire ?");
    Console.WriteLine("Action n°" + choix + " choisie");

    switch (choix)
    {
        case 1: AjouterEmploye(); break;

        case 2: Console.WriteLine(string.Join("\n",monController.Afficher())); break;

        case 3: Console.WriteLine(monController.Rechercher(ConsoleHelper.GetInputIntUser("Saisir l'id de l'employé à afficher :"))); break;

        default: break;
    }

}


