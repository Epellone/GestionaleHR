using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTitolodistudio : IRepositoryTitolodistudio
    {
        private ApplicationDbContext dbtitolodistudio;

        public RepositoryTitolodistudio(ApplicationDbContext dbcontext)
        {
            this.dbtitolodistudio = dbcontext;
        }

        public List<Titolidistudio> GetAll()
        {
            return dbtitolodistudio.Titolidistudio.ToList();
        }

        public Titolidistudio GetById(int id)
        {
            return dbtitolodistudio.Titolidistudio.Where(a => a.IDTitolodistudio == id).SingleOrDefault();
        }

        public Titolidistudio Add(Titolidistudio titolodistudio)
        {
            var add = dbtitolodistudio.Titolidistudio.Add(titolodistudio);
            dbtitolodistudio.SaveChanges();
            return add.Entity;
        }

        public Titolidistudio Update(Titolidistudio titolodistudio)
        {
            var update = dbtitolodistudio.Titolidistudio.Update(titolodistudio);
            dbtitolodistudio.SaveChanges();
            return update.Entity;
        }

        public Titolidistudio RemovebyId(int id)
        {
            var remove = dbtitolodistudio.Titolidistudio.Remove(GetById(id));
            dbtitolodistudio.SaveChanges();
            return remove.Entity;
        }
    }
}
