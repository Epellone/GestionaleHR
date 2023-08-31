using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTipologiaContratto : IRepositoryTipologiaContratto
    {
        private ApplicationDbContext dbtipologiacontratto;

        public RepositoryTipologiaContratto(ApplicationDbContext dbcontext)
        {
            this.dbtipologiacontratto = dbcontext;
        }

        public List<Tipologiacontratto> GetAll()
        {
            return dbtipologiacontratto.Tipocontratto.ToList();
        }

        public Tipologiacontratto GetById(int id)
        {
            return dbtipologiacontratto.Tipocontratto.Where(a => a.IDTipologiacontratto == id).SingleOrDefault();
        }

        public Tipologiacontratto Add(Tipologiacontratto tipologiacontratto)
        {
            var add = dbtipologiacontratto.Tipocontratto.Add(tipologiacontratto);
            dbtipologiacontratto.SaveChanges();
            return add.Entity;
        }

        public Tipologiacontratto Update(Tipologiacontratto tipologiacontratto)
        {
            var update = dbtipologiacontratto.Tipocontratto.Update(tipologiacontratto);
            dbtipologiacontratto.SaveChanges();
            return update.Entity;
        }

        public Tipologiacontratto RemovebyId(int id)
        {
            var remove = dbtipologiacontratto.Tipocontratto.Remove(GetById(id));
            dbtipologiacontratto.SaveChanges();
            return remove.Entity;
        }
    }
}
