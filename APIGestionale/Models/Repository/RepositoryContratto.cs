using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryContratto : IRepositoryContratto
    {
        private ApplicationDbContext dbcontratto;

        public RepositoryContratto(ApplicationDbContext dbcontext)
        {
            this.dbcontratto = dbcontext;
        }

        public List<Contratto> GetAll()
        {
            return dbcontratto.Contratto.ToList();
        }

        public Contratto GetById(int id)
        {
            return dbcontratto.Contratto.Where(a => a.IDContratto == id).SingleOrDefault();
        }

        public Contratto Add(Contratto contratto)
        {
            var add = dbcontratto.Contratto.Add(contratto);
            dbcontratto.SaveChanges();
            return add.Entity;
        }

        public Contratto Update(Contratto contratto)
        {
            var update = dbcontratto.Contratto.Update(contratto);
            dbcontratto.SaveChanges();
            return update.Entity;
        }

        public Contratto RemovebyId(int id)
        {
            var remove = dbcontratto.Contratto.Remove(GetById(id));
            dbcontratto.SaveChanges();
            return remove.Entity;
        }
    }
}
