namespace APIGestionale.Models.Interface
{
    public interface IRepositoryBenefits
    {
        public List<Benefits> GetAll();
        public Benefits GetById(int id);
        public Benefits Add(Benefits benefits);
        public Benefits Update(Benefits benefits);
        public Benefits RemovebyId(int id);
    }
}
