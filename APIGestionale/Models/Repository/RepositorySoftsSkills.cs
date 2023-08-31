using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositorySoftsSkills : IRepositorySoftSkills
    {
        private ApplicationDbContext dbsoftskills;

        public RepositorySoftsSkills(ApplicationDbContext dbcontext)
        {
            this.dbsoftskills = dbcontext;
        }

        public List<SoftSkills> GetAll()
        {
            return dbsoftskills.Softskills.ToList();
        }

        public SoftSkills GetById(int id)
        {
            return dbsoftskills.Softskills.Where(a => a.IDSoftSkills == id).SingleOrDefault();
        }

        public SoftSkills Add(SoftSkills softskills)
        {
            var add = dbsoftskills.Softskills.Add(softskills);
            dbsoftskills.SaveChanges();
            return add.Entity;
        }

        public SoftSkills Update(SoftSkills softskills)
        {
            var update = dbsoftskills.Softskills.Update(softskills);
            dbsoftskills.SaveChanges();
            return update.Entity;
        }

        public SoftSkills RemovebyId(int id)
        {
            var remove = dbsoftskills.Softskills.Remove(GetById(id));
            dbsoftskills.SaveChanges();
            return remove.Entity;
        }
    }
}
