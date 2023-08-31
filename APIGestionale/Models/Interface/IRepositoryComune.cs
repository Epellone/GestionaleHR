namespace APIGestionale.Models.Interface
{
    public interface IRepositoryComune
    {
        public List<Comune> GetAll();
        public Comune GetById(int id);
        public Comune Add(Comune comune);
        public Comune Update(Comune comune);
        public Comune RemovebyId(int id);
    }
}
