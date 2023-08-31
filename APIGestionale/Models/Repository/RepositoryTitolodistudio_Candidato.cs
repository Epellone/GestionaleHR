using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTitolodistudio_Candidato : IRepositoryTitolodistudio_Candidato
    {

        private ApplicationDbContext dbtitolodistudiocandidato;

        public RepositoryTitolodistudio_Candidato(ApplicationDbContext dbcontext)
        {
            this.dbtitolodistudiocandidato = dbcontext;
        }

        public List<Titolodistudio_Candidato> GetAll()
        {
            return dbtitolodistudiocandidato.Titolidistudio_candidato.ToList();
        }

        public Titolodistudio_Candidato GetById(int id)
        {
            return dbtitolodistudiocandidato.Titolidistudio_candidato.Where(a => a.IDTitolodistudio_Candidato == id).SingleOrDefault();
        }

        public Titolodistudio_Candidato Add(Titolodistudio_Candidato titolodistudio_candidato)
        {
            var add = dbtitolodistudiocandidato.Titolidistudio_candidato.Add(titolodistudio_candidato);
            dbtitolodistudiocandidato.SaveChanges();
            return add.Entity;
        }

        public Titolodistudio_Candidato Update(Titolodistudio_Candidato titolodistudio_candidato)
        {
            var update = dbtitolodistudiocandidato.Titolidistudio_candidato.Update(titolodistudio_candidato);
            dbtitolodistudiocandidato.SaveChanges();
            return update.Entity;
        }

        public Titolodistudio_Candidato RemovebyId(int id)
        {
            var remove = dbtitolodistudiocandidato.Titolidistudio_candidato.Remove(GetById(id));
            dbtitolodistudiocandidato.SaveChanges();
            return remove.Entity;
        }
    }
}
