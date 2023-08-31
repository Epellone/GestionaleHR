using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryComune : IRepositoryComune 
    {
        private ApplicationDbContext dbcomune;

        public RepositoryComune(ApplicationDbContext dbcontext)
        {
            this.dbcomune = dbcontext;
        }

        public List<Comune> GetAll()
        {
            return dbcomune.Comune.ToList();
        }

        public Comune GetById(int id)
        {
            return dbcomune.Comune.Where(a => a.IDComune == id).SingleOrDefault();
        }

        public Comune Add(Comune comune)
        {
            var add = dbcomune.Comune.Add(comune);
            dbcomune.SaveChanges();
            return add.Entity;
        }

        public Comune Update(Comune comune)
        {
            var update = dbcomune.Comune.Update(comune);
            dbcomune.SaveChanges();
            return update.Entity;
        }

        public Comune RemovebyId(int id)
        {
            var remove = dbcomune.Comune.Remove(GetById(id));
            dbcomune.SaveChanges();
            return remove.Entity;
        }
    }
}
