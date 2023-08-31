using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryBenefits_Contratto : IRepositoryBenefits_Contratto
    {
        private ApplicationDbContext dbbenefitcontratto;

        public RepositoryBenefits_Contratto(ApplicationDbContext dbcontext)
        {
            this.dbbenefitcontratto = dbcontext;
        }

        public List<Benefits_Contratto> GetAll()
        {
            return dbbenefitcontratto.Benefit_contratto.ToList();
        }

        public Benefits_Contratto GetById(int id)
        {
            return dbbenefitcontratto.Benefit_contratto.Where(a => a.IDBenefits_Contratto == id).SingleOrDefault();
        }

        public Benefits_Contratto Add(Benefits_Contratto benefitscontratto)
        {
            var add = dbbenefitcontratto.Benefit_contratto.Add(benefitscontratto);
            dbbenefitcontratto.SaveChanges();
            return add.Entity;
        }

        public Benefits_Contratto Update(Benefits_Contratto benefitscontratto)
        {
            var update = dbbenefitcontratto.Benefit_contratto.Update(benefitscontratto);
            dbbenefitcontratto.SaveChanges();
            return update.Entity;
        }

        public Benefits_Contratto RemovebyId(int id)
        {
            var remove = dbbenefitcontratto.Benefit_contratto.Remove(GetById(id));
            dbbenefitcontratto.SaveChanges();
            return remove.Entity;
        }
    }
}
