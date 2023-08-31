using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryCandidato : IRepositoryCandidato
    {
        private ApplicationDbContext dbcandidato;

        public RepositoryCandidato(ApplicationDbContext dbcontext)
        {
            this.dbcandidato = dbcontext;
        }

        public List<Candidato> GetAll()
        {
            return dbcandidato.Candidato.ToList();
        }

        public Candidato GetById(int id)
        {
            return dbcandidato.Candidato.Where(a => a.IDCandidato == id).SingleOrDefault();
        }

        public Candidato Add(Candidato candidato)
        {
            var add = dbcandidato.Candidato.Add(candidato);
            dbcandidato.SaveChanges();
            return add.Entity;
        }

        public Candidato Update(Candidato candidato)
        {
            var update = dbcandidato.Candidato.Update(candidato);
            dbcandidato.SaveChanges();
            return update.Entity;
        }

        public Candidato RemovebyId(int id)
        {
            var remove = dbcandidato.Candidato.Remove(GetById(id));
            dbcandidato.SaveChanges();
            return remove.Entity;
        }
    }
}
