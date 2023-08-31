namespace APIGestionale.Models.Interface
{
    public interface IRepositoryProvincia
    {
        public List<Provincia> GetAll();
        public Provincia GetById(int id);
        public Provincia Add(Provincia provincia);
        public Provincia Update(Provincia provincia);
        public Provincia RemovebyId(int id);
    }
}
