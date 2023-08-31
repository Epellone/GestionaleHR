using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositorySoftSkill_Candidato : IRepositorySoftSkills_Candidato
    {
        private ApplicationDbContext dbsoftskills_candidato;

        public RepositorySoftSkill_Candidato(ApplicationDbContext dbcontext)
        {
            this.dbsoftskills_candidato = dbcontext;
        }

        public List<SoftSkills_Candidato> GetAll()
        {
            return dbsoftskills_candidato.Softskills_candidato.ToList();
        }

        public SoftSkills_Candidato GetById(int id)
        {
            return dbsoftskills_candidato.Softskills_candidato.Where(a => a.IDSoftSkills_Candidato == id).SingleOrDefault();
        }

        public SoftSkills_Candidato Add(SoftSkills_Candidato softskills_candidato)
        {
            var add = dbsoftskills_candidato.Softskills_candidato.Add(softskills_candidato);
            dbsoftskills_candidato.SaveChanges();
            return add.Entity;
        }

        public SoftSkills_Candidato Update(SoftSkills_Candidato softskills_candidato)
        {
            var update = dbsoftskills_candidato.Softskills_candidato.Update(softskills_candidato);
            dbsoftskills_candidato.SaveChanges();
            return update.Entity;
        }

        public SoftSkills_Candidato RemovebyId(int id)
        {
            var remove = dbsoftskills_candidato.Softskills_candidato.Remove(GetById(id));
            dbsoftskills_candidato.SaveChanges();
            return remove.Entity;
        }
    }
}
