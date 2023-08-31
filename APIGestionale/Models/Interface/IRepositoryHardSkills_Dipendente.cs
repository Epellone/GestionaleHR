namespace APIGestionale.Models.Interface
{
    public interface IRepositoryHardSkills_Dipendente
    {
        public List<HardSkill_Dipendente> GetAll();
        public HardSkill_Dipendente GetById(int id);
        public HardSkill_Dipendente Add(HardSkill_Dipendente hardskilldipendente);
        public HardSkill_Dipendente Update(HardSkill_Dipendente hardskilldipendente);
        public HardSkill_Dipendente RemovebyId(int id);
    }
}
