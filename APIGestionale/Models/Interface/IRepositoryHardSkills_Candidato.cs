namespace APIGestionale.Models.Interface
{
    public interface IRepositoryHardSkills_Candidato
    {
        public List<HardSkill_Candidato> GetAll();
        public HardSkill_Candidato GetById(int id);
        public HardSkill_Candidato Add(HardSkill_Candidato hardskills_candidato);
        public HardSkill_Candidato Update(HardSkill_Candidato hardskills_candidato);
        public HardSkill_Candidato RemovebyId(int id);
    }
}
