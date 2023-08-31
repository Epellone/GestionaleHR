namespace APIGestionale.Models.Interface
{
    public interface IRepositoryContratto
    {
        public List<Contratto> GetAll();
        public Contratto GetById(int id);
        public Contratto Add(Contratto contratto);
        public Contratto Update(Contratto contratto);
        public Contratto RemovebyId(int id);
    }
}
