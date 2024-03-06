using Entities;

namespace Business.Contracts
{
    public interface IEmployeBusiness
    {
        public void AjouterEmploye(Employe employe);
        public List<Employe> Afficher();
        public Employe? Rechercher(int id);
    }
}
