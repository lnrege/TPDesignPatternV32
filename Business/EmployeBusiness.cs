using Business.Contracts;
using Entities;
using Repository;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class EmployeBusiness : IEmployeBusiness
    {
        private IEmployeRepository _employeRep; 
        public EmployeBusiness(IEmployeRepository employeRepository)
        {
            _employeRep = employeRepository;
        }

        public void AjouterEmploye(Employe employe)
        {
            if(employe.Salaire > 0) {_employeRep.AjouterEmploye(employe); }
        }

        public List<Employe> Afficher()
        {
            return _employeRep.Afficher();
        }

        public Employe? Rechercher(int id)
        {
            return _employeRep.Rechercher(id);

        }
    }
}
