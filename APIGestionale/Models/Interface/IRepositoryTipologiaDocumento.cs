namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTipologiaDocumento
    {
        public List<Tipologiadocumento> GetAll();
        public Tipologiadocumento GetById(int id);
        public Tipologiadocumento Add(Tipologiadocumento tipologiadocumento);
        public Tipologiadocumento Update(Tipologiadocumento tipologiadocumento);
        public Tipologiadocumento RemovebyId(int id);
    }
}
