namespace APIGestionale.Models.Interface
{
    public interface IRepositoryDipendente
    {
        public List<Dipendente> GetAll();
        public Dipendente GetById(int id);
        public Dipendente Add(Dipendente dipendente);
        public Dipendente Update(Dipendente dipendente);
        public Dipendente RemovebyId(int id);
    }
}
