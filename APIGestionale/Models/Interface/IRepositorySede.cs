namespace APIGestionale.Models.Interface
{
    public interface IRepositorySede
    {
        public List<Sede> GetAll();
        public Sede GetById(int id);
        public Sede Add(Sede sede);
        public Sede Update(Sede sede);
        public Sede RemovebyId(int id);

    }
}
