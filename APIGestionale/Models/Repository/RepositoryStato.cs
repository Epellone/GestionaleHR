using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryStato : IRepositoryStato
    {
        private ApplicationDbContext dbstato;

        public RepositoryStato(ApplicationDbContext dbcontext)
        {
            this.dbstato = dbcontext;
        }

        public List<Stato> GetAll()
        {
            return dbstato.Stato.ToList();
        }

        public Stato GetById(int id)
        {
            return dbstato.Stato.Where(a => a.IDStato == id).SingleOrDefault();
        }

        public Stato Add(Stato stato)
        {
            var add = dbstato.Stato.Add(stato);
            dbstato.SaveChanges();
            return add.Entity;
        }

        public Stato Update(Stato stato)
        {
            var update = dbstato.Stato.Update(stato);
            dbstato.SaveChanges();
            return update.Entity;
        }

        public Stato RemovebyId(int id)
        {
            var remove = dbstato.Stato.Remove(GetById(id));
            dbstato.SaveChanges();
            return remove.Entity;
        }
    }
}
