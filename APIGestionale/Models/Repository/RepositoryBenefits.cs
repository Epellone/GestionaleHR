using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryBenefits : IRepositoryBenefits
    {
        private ApplicationDbContext dbbenefit;

        public RepositoryBenefits(ApplicationDbContext dbcontext)
        {
            this.dbbenefit = dbcontext;
        }

        public List<Benefits> GetAll()
        {
            return dbbenefit.Benefit.ToList();
        }

        public Benefits GetById(int id)
        {
            return dbbenefit.Benefit.Where(a => a.IDBenefit == id).SingleOrDefault();
        }

        public Benefits Add(Benefits benefits)
        {
            var add = dbbenefit.Benefit.Add(benefits);
            dbbenefit.SaveChanges();
            return add.Entity;
        }

        public Benefits Update(Benefits benefits)
        {
            var update = dbbenefit.Benefit.Update(benefits);
            dbbenefit.SaveChanges();
            return update.Entity;
        }

        public Benefits RemovebyId(int id)
        {
            var remove = dbbenefit.Benefit.Remove(GetById(id));
            dbbenefit.SaveChanges();
            return remove.Entity;
        }
    }
}
