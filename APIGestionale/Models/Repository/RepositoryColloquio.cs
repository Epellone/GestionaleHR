using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryColloquio : IRepositoryColloquio
    {
        private ApplicationDbContext dbcolloquio;

        public RepositoryColloquio(ApplicationDbContext dbcontext)
        {
            this.dbcolloquio = dbcontext;
        }

        public List<Colloquio> GetAll()
        {
            return dbcolloquio.Colloquio.ToList();
        }

        public Colloquio GetById(int id)
        {
            return dbcolloquio.Colloquio.Where(a => a.IDColloquio == id).SingleOrDefault();
        }

        public Colloquio Add(Colloquio colloquio)
        {
            var add = dbcolloquio.Colloquio.Add(colloquio);
            dbcolloquio.SaveChanges();
            return add.Entity;
        }

        public Colloquio Update(Colloquio colloquio)
        {
            var update = dbcolloquio.Colloquio.Update(colloquio);
            dbcolloquio.SaveChanges();
            return update.Entity;
        }

        public Colloquio RemovebyId(int id)
        {
            var remove = dbcolloquio.Colloquio.Remove(GetById(id));
            dbcolloquio.SaveChanges();
            return remove.Entity;
        }
    }
}
