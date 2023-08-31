using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTipologiaDocumento : IRepositoryTipologiaDocumento
    {
        private ApplicationDbContext dbtipologiadocumento;

        public RepositoryTipologiaDocumento(ApplicationDbContext dbcontext)
        {
            this.dbtipologiadocumento = dbcontext;
        }

        public List<Tipologiadocumento> GetAll()
        {
            return dbtipologiadocumento.Tipodocumento.ToList();
        }

        public Tipologiadocumento GetById(int id)
        {
            return dbtipologiadocumento.Tipodocumento.Where(a => a.IDTipologiadocumento == id).SingleOrDefault();
        }

        public Tipologiadocumento Add(Tipologiadocumento tipologiadocumento)
        {
            var add = dbtipologiadocumento.Tipodocumento.Add(tipologiadocumento);
            dbtipologiadocumento.SaveChanges();
            return add.Entity;
        }

        public Tipologiadocumento Update(Tipologiadocumento tipologiadocumento)
        {
            var update = dbtipologiadocumento.Tipodocumento.Update(tipologiadocumento);
            dbtipologiadocumento.SaveChanges();
            return update.Entity;
        }

        public Tipologiadocumento RemovebyId(int id)
        {
            var remove = dbtipologiadocumento.Tipodocumento.Remove(GetById(id));
            dbtipologiadocumento.SaveChanges();
            return remove.Entity;
        }
    }
}

