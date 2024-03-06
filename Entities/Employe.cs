using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employe
    {

        private int _id;
        private string _nom;
        private string _prenom;
        private int _salaire;

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Salaire
        {
            get { return _salaire; }
            set
            {
                if (_salaire < 0)
                {
                    throw new ArgumentOutOfRangeException("Error Salary < 0 !!!");
                }
                else _salaire = value;
            }
        }
        public Employe() { }

        public Employe(int _id, string _nom, string _prenom, int _salaire)
        {
            Id = _id;
            Nom = _nom;
            Prenom = _prenom;
            Salaire = _salaire;
        }

        public override string ToString()
        {
            return $"ID {Id} - Nom : {Nom} - Prénom : {Prenom} - Salaire : {Salaire}";
        }

    }
}

