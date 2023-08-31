using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryLivelloContrattuale : IRepositoryLivelloContrattuale
    {
        private ApplicationDbContext dblivellocontrattuale;

        public RepositoryLivelloContrattuale(ApplicationDbContext dbcontext)
        {
            this.dblivellocontrattuale = dbcontext;
        }

        public List<Livellocontrattuale> GetAll()
        {
            return dblivellocontrattuale.Livellocontrattuale.ToList();
        }

        public Livellocontrattuale GetById(int id)
        {
            return dblivellocontrattuale.Livellocontrattuale.Where(a => a.IDLivelloContrattuale == id).SingleOrDefault();
        }

        public Livellocontrattuale Add(Livellocontrattuale livellocontrattuale)
        {
            var add = dblivellocontrattuale.Livellocontrattuale.Add(livellocontrattuale);
            dblivellocontrattuale.SaveChanges();
            return add.Entity;
        }

        public Livellocontrattuale Update(Livellocontrattuale livellocontrattuale)
        {
            var update = dblivellocontrattuale.Livellocontrattuale.Update(livellocontrattuale);
            dblivellocontrattuale.SaveChanges();
            return update.Entity;
        }

        public Livellocontrattuale RemovebyId(int id)
        {
            var remove = dblivellocontrattuale.Livellocontrattuale.Remove(GetById(id));
            dblivellocontrattuale.SaveChanges();
            return remove.Entity;
        }
    }
}
