namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTipologiaContratto
    {
        public List<Tipologiacontratto> GetAll();
        public Tipologiacontratto GetById(int id);
        public Tipologiacontratto Add(Tipologiacontratto tipologiacontratto);
        public Tipologiacontratto Update(Tipologiacontratto tipologiacontratto);
        public Tipologiacontratto RemovebyId(int id);
    }
}
