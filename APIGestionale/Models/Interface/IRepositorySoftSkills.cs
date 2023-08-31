namespace APIGestionale.Models.Interface
{
    public interface IRepositorySoftSkills
    {
        public List<SoftSkills> GetAll();
        public SoftSkills GetById(int id);
        public SoftSkills Add(SoftSkills softskills);
        public SoftSkills Update(SoftSkills softskills);
        public SoftSkills RemovebyId(int id);
    }
}
