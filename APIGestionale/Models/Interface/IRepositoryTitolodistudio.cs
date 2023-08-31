namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTitolodistudio
    {
        public List<Titolidistudio> GetAll();
        public Titolidistudio GetById(int id);
        public Titolidistudio Add(Titolidistudio titolodistudio);
        public Titolidistudio Update(Titolidistudio titolodistudio);
        public Titolidistudio RemovebyId(int id);
    }
}
