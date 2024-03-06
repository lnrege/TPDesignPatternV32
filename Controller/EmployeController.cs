using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Business.Contracts;
using Entities;
using Repository;



namespace Controller
{
    public class EmployeController
    {
        private IEmployeBusiness _employeBusiness;

        public EmployeController(IEmployeBusiness employeBusiness)
        {
            _employeBusiness = employeBusiness;
        }
        public void AjouterEmploye(int id, string nom, string prenom, int salaire)
        {
            Employe employe = new Employe(id, nom, prenom, salaire);
            _employeBusiness.AjouterEmploye(employe);
        }

        public List<Employe> Afficher()
        {
            return _employeBusiness.Afficher();
        }

        public Employe? Rechercher(int id)
        {
            return _employeBusiness.Rechercher(id);
        }
    }
}
