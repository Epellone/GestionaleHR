namespace APIGestionale.Models.Interface
{
    public interface IRepositoryRuolo
    {
        public List<Ruolo> GetAll();
        public Ruolo GetById(int id);
        public Ruolo Add(Ruolo ruolo);
        public Ruolo Update(Ruolo ruolo);
        public Ruolo RemovebyId(int id);
    }
}
