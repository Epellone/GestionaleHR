using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositorySedi : IRepositorySede
    {
        private ApplicationDbContext dbsede;

        public RepositorySedi(ApplicationDbContext dbcontext)
        {
            this.dbsede = dbcontext;
        }

        public List<Sede> GetAll()
        {
            return dbsede.Sedi.ToList();
        }

        public Sede GetById(int id)
        {
            return dbsede.Sedi.Where(a => a.IDSede == id).SingleOrDefault();
        }

        public Sede Add(Sede sede)
        {
            var add = dbsede.Sedi.Add(sede);
            dbsede.SaveChanges();
            return add.Entity;
        }

        public Sede Update(Sede sede)
        {
            var update = dbsede.Sedi.Update(sede);
            dbsede.SaveChanges();
            return update.Entity;
        }

        public Sede RemovebyId(int id)
        {
            var remove = dbsede.Sedi.Remove(GetById(id));
            dbsede.SaveChanges();
            return remove.Entity;
        }
    }
}
