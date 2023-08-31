using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryHardSkill_Dipendente : IRepositoryHardSkills_Dipendente
    {
        private ApplicationDbContext dbhardskill_dipendente;

        public RepositoryHardSkill_Dipendente(ApplicationDbContext dbcontext)
        {
            this.dbhardskill_dipendente = dbcontext;
        }

        public List<HardSkill_Dipendente> GetAll()
        {
            return dbhardskill_dipendente.Hardskills_dipendente.ToList();
        }

        public HardSkill_Dipendente GetById(int id)
        {
            return dbhardskill_dipendente.Hardskills_dipendente.Where(a => a.IDHardSkill_Dipendente == id).SingleOrDefault();
        }

        public HardSkill_Dipendente Add(HardSkill_Dipendente hardskill_dipendente)
        {
            var add = dbhardskill_dipendente.Hardskills_dipendente.Add(hardskill_dipendente);
            dbhardskill_dipendente.SaveChanges();
            return add.Entity;
        }

        public HardSkill_Dipendente Update(HardSkill_Dipendente hardskill_dipendente)
        {
            var update = dbhardskill_dipendente.Hardskills_dipendente.Update(hardskill_dipendente);
            dbhardskill_dipendente.SaveChanges();
            return update.Entity;
        }

        public HardSkill_Dipendente RemovebyId(int id)
        {
            var remove = dbhardskill_dipendente.Hardskills_dipendente.Remove(GetById(id));
            dbhardskill_dipendente.SaveChanges();
            return remove.Entity;
        }
    }
}
