using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTipologiaColloquio : IRepositoryTipologiaColloquio
    {
        private ApplicationDbContext dbtipologiacolloquio;

        public RepositoryTipologiaColloquio(ApplicationDbContext dbcontext)
        {
            this.dbtipologiacolloquio = dbcontext;
        }

        public List<Tipologiacolloquio> GetAll()
        {
            return dbtipologiacolloquio.Tipocolloquio.ToList();
        }

        public Tipologiacolloquio GetById(int id)
        {
            return dbtipologiacolloquio.Tipocolloquio.Where(a => a.IDTipologiacolloquio == id).SingleOrDefault();
        }

        public Tipologiacolloquio Add(Tipologiacolloquio tipologiacolloquio)
        {
            var add = dbtipologiacolloquio.Tipocolloquio.Add(tipologiacolloquio);
            dbtipologiacolloquio.SaveChanges();
            return add.Entity;
        }

        public Tipologiacolloquio Update(Tipologiacolloquio tipologiacolloquio)
        {
            var update = dbtipologiacolloquio.Tipocolloquio.Update(tipologiacolloquio);
            dbtipologiacolloquio.SaveChanges();
            return update.Entity;
        }

        public Tipologiacolloquio RemovebyId(int id)
        {
            var remove = dbtipologiacolloquio.Tipocolloquio.Remove(GetById(id));
            dbtipologiacolloquio.SaveChanges();
            return remove.Entity;
        }
    }
}
