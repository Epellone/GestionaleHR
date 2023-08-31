namespace APIGestionale.Models.Interface
{
    public interface IRepositoryLivelloContrattuale
    {
        public List<Livellocontrattuale> GetAll();
        public Livellocontrattuale GetById(int id);
        public Livellocontrattuale Add(Livellocontrattuale livellocontrattuale);
        public Livellocontrattuale Update(Livellocontrattuale livellocontrattuale);
        public Livellocontrattuale RemovebyId(int id);
    }
}
