using APIGestionale.Models.Interface;


namespace APIGestionale.Models.Repository
{
    public class RepositoryHardSkill_Candidato : IRepositoryHardSkills_Candidato
    {
        private ApplicationDbContext dbhardskill_candidato;

        public RepositoryHardSkill_Candidato(ApplicationDbContext dbcontext)
        {
            this.dbhardskill_candidato = dbcontext;
        }

        public List<HardSkill_Candidato> GetAll()
        {
            return dbhardskill_candidato.Hardskills_candidato.ToList();
        }

        public HardSkill_Candidato GetById(int id)
        {
            return dbhardskill_candidato.Hardskills_candidato.Where(a => a.IDHardSkill_Candidato == id).SingleOrDefault();
        }

        public HardSkill_Candidato Add(HardSkill_Candidato hardskill_candidato)
        {
            var add = dbhardskill_candidato.Hardskills_candidato.Add(hardskill_candidato);
            dbhardskill_candidato.SaveChanges();
            return add.Entity;
        }

        public HardSkill_Candidato Update(HardSkill_Candidato hardskill_candidato)
        {
            var update = dbhardskill_candidato.Hardskills_candidato.Update(hardskill_candidato);
            dbhardskill_candidato.SaveChanges();
            return update.Entity;
        }

        public HardSkill_Candidato RemovebyId(int id)
        {
            var remove = dbhardskill_candidato.Hardskills_candidato.Remove(GetById(id));
            dbhardskill_candidato.SaveChanges();
            return remove.Entity;
        }
    }
}
