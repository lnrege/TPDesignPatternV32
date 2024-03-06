using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repository
{
    public class LocalStorage
    {
        public List<Employe> listeEmploye = new List<Employe>()
        {
            new Employe(0001, "DUPONT", "Jacques", 45000),
            new Employe(0002, "DURAND", "Paulette", 37000),
            new Employe(0007, "BOND", "James", 130000),
            new Employe(0005, "CAT", "Women", 200000)
        };

        private static LocalStorage instance = null;
        private LocalStorage() { }
        public static LocalStorage Instance
        {
            get
            {
                if (instance == null) { instance = new LocalStorage(); }
                return instance;
            }
        }

    }
}
