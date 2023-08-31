namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTipologiaColloquio
    {
        public List<Tipologiacolloquio> GetAll();
        public Tipologiacolloquio GetById(int id);
        public Tipologiacolloquio Add(Tipologiacolloquio tipologiacolloquio);
        public Tipologiacolloquio Update(Tipologiacolloquio tipologiacolloquio);
        public Tipologiacolloquio RemovebyId(int id);
    }
}
