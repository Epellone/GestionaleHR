namespace APIGestionale.Models.Interface
{
    public interface IRepositoryBenefits_Contratto
    {
        public List<Benefits_Contratto> GetAll();
        public Benefits_Contratto GetById(int id);
        public Benefits_Contratto Add(Benefits_Contratto benefitscontratto);
        public Benefits_Contratto Update(Benefits_Contratto benefitscontratto);
        public Benefits_Contratto RemovebyId(int id);
    }
}
