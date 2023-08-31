using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositorySoftSkill_Dipendente : IRepositorySoftSkills_Dipendente
    {
        private ApplicationDbContext dbsoftskills_dipendente;

        public RepositorySoftSkill_Dipendente(ApplicationDbContext dbcontext)
        {
            this.dbsoftskills_dipendente = dbcontext;
        }

        public List<SoftSkills_Dipendente> GetAll()
        {
            return dbsoftskills_dipendente.Softskills_dipendente.ToList();
        }

        public SoftSkills_Dipendente GetById(int id)
        {
            return dbsoftskills_dipendente.Softskills_dipendente.Where(a => a.IDSoftSkills_Dipendente == id).SingleOrDefault();
        }

        public SoftSkills_Dipendente Add(SoftSkills_Dipendente softskills_dipendente)
        {
            var add = dbsoftskills_dipendente.Softskills_dipendente.Add(softskills_dipendente);
            dbsoftskills_dipendente.SaveChanges();
            return add.Entity;
        }

        public SoftSkills_Dipendente Update(SoftSkills_Dipendente softskills_dipendente)
        {
            var update = dbsoftskills_dipendente.Softskills_dipendente.Update(softskills_dipendente);
            dbsoftskills_dipendente.SaveChanges();
            return update.Entity;
        }

        public SoftSkills_Dipendente RemovebyId(int id)
        {
            var remove = dbsoftskills_dipendente.Softskills_dipendente.Remove(GetById(id));
            dbsoftskills_dipendente.SaveChanges();
            return remove.Entity;
        }
    }
}
