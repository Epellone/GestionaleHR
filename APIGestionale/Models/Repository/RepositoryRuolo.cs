using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryRuolo : IRepositoryRuolo
    {
        private ApplicationDbContext dbruolo;

        public RepositoryRuolo(ApplicationDbContext dbcontext)
        {
            this.dbruolo = dbcontext;
        }

        public List<Ruolo> GetAll()
        {
            return dbruolo.Ruolo.ToList();
        }

        public Ruolo GetById(int id)
        {
            return dbruolo.Ruolo.Where(a => a.IDRuolo == id).SingleOrDefault();
        }

        public Ruolo Add(Ruolo ruolo)
        {
            var add = dbruolo.Ruolo.Add(ruolo);
            dbruolo.SaveChanges();
            return add.Entity;
        }

        public Ruolo Update(Ruolo ruolo)
        {
            var update = dbruolo.Ruolo.Update(ruolo);
            dbruolo.SaveChanges();
            return update.Entity;
        }

        public Ruolo RemovebyId(int id)
        {
            var remove = dbruolo.Ruolo.Remove(GetById(id));
            dbruolo.SaveChanges();
            return remove.Entity;
        }
    }
}
