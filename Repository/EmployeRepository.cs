using Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeRepository : IEmployeRepository
    {
        private LocalStorage _localStorage;
        public EmployeRepository()
        {
             _localStorage = LocalStorage.Instance;
        }
        public void AjouterEmploye(Employe employe)
        {
            _localStorage.listeEmploye.Add(employe);
        }

        public List<Employe> Afficher()
        {
            return _localStorage.listeEmploye;
        }

        public Employe? Rechercher(int id)
        {
            return _localStorage.listeEmploye.FirstOrDefault(p => p.Id == id);

        }
    }
}
