using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryProvincia : IRepositoryProvincia
    {
        private ApplicationDbContext dbprovincia;

        public RepositoryProvincia(ApplicationDbContext dbcontext)
        {
            this.dbprovincia = dbcontext;
        }

        public List<Provincia> GetAll()
        {
            return dbprovincia.Provincia.ToList();
        }

        public Provincia GetById(int id)
        {
            return dbprovincia.Provincia.Where(a => a.IDProvincia == id).SingleOrDefault();
        }

        public Provincia Add(Provincia provincia)
        {
            var add = dbprovincia.Provincia.Add(provincia);
            dbprovincia.SaveChanges();
            return add.Entity;
        }

        public Provincia Update(Provincia provincia)
        {
            var update = dbprovincia.Provincia.Update(provincia);
            dbprovincia.SaveChanges();
            return update.Entity;
        }

        public Provincia RemovebyId(int id)
        {
            var remove = dbprovincia.Provincia.Remove(GetById(id));
            dbprovincia.SaveChanges();
            return remove.Entity;
        }
    }
}
