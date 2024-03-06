using Entities;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        public void AjouterEmploye(Employe employe);
        public List<Employe> Afficher();
        public Employe? Rechercher(int id);

    }
}
