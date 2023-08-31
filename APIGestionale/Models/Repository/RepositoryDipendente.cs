using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryDipendente : IRepositoryDipendente
    {
        private ApplicationDbContext dbdipendente;

        public RepositoryDipendente(ApplicationDbContext dbcontext)
        {
            this.dbdipendente = dbcontext;
        }

        public List<Dipendente> GetAll()
        {
            return dbdipendente.Dipendente.ToList();
        }

        public Dipendente GetById(int id)
        {
            return dbdipendente.Dipendente.Where(a => a.IdDipendente == id).SingleOrDefault();
        }

        public Dipendente Add(Dipendente dipendente)
        {
            var add = dbdipendente.Dipendente.Add(dipendente);
            dbdipendente.SaveChanges();
            return add.Entity;
        }

        public Dipendente Update(Dipendente dipendente)
        {
            var update = dbdipendente.Dipendente.Update(dipendente);
            dbdipendente.SaveChanges();
            return update.Entity;
        }

        public Dipendente RemovebyId(int id)
        {
            var remove = dbdipendente.Dipendente.Remove(GetById(id));
            dbdipendente.SaveChanges();
            return remove.Entity;
        }
    }
}
