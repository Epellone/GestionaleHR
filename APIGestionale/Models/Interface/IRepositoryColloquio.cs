namespace APIGestionale.Models.Interface
{
    public interface IRepositoryColloquio
    {
        public List<Colloquio> GetAll();
        public Colloquio GetById(int id);
        public Colloquio Add(Colloquio colloquio);
        public Colloquio Update(Colloquio colloquio);
        public Colloquio RemovebyId(int id);
    }
}
