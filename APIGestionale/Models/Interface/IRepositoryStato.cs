namespace APIGestionale.Models.Interface
{
    public interface IRepositoryStato
    {
        public List<Stato> GetAll();
        public Stato GetById(int id);
        public Stato Add(Stato stato);
        public Stato Update(Stato stato);
        public Stato RemovebyId(int id);
    }
}
