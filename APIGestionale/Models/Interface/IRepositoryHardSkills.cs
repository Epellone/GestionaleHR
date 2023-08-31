namespace APIGestionale.Models.Interface
{
    public interface IRepositoryHardSkills
    {
        public List<HardSkills> GetAll();
        public HardSkills GetById(int id);
        public HardSkills Add(HardSkills hardskills);
        public HardSkills Update(HardSkills hardskills);
        public HardSkills RemovebyId(int id);
    }
}
