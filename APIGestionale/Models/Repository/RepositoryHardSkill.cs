using APIGestionale.Models.Interface;


namespace APIGestionale.Models.Repository
{
    public class RepositoryHardSkill : IRepositoryHardSkills
    {
        private ApplicationDbContext dbhardskill;

        public RepositoryHardSkill(ApplicationDbContext dbcontext)
        {
            this.dbhardskill = dbcontext;
        }

        public List<HardSkills> GetAll()
        {
            return dbhardskill.Hardskills.ToList();
        }

        public HardSkills GetById(int id)
        {
            return dbhardskill.Hardskills.Where(a => a.IDHardSkills == id).SingleOrDefault();
        }

        public HardSkills Add(HardSkills hardskills)
        {
            var add = dbhardskill.Hardskills.Add(hardskills);
            dbhardskill.SaveChanges();
            return add.Entity;
        }

        public HardSkills Update(HardSkills hardskills)
        {
            var update = dbhardskill.Hardskills.Update(hardskills);
            dbhardskill.SaveChanges();
            return update.Entity;
        }

        public HardSkills RemovebyId(int id)
        {
            var remove = dbhardskill.Hardskills.Remove(GetById(id));
            dbhardskill.SaveChanges();
            return remove.Entity;
        }
    }
}
