namespace APIGestionale.Models.Interface
{
    public interface IRepositorySoftSkills_Candidato
    {
        public List<SoftSkills_Candidato> GetAll();
        public SoftSkills_Candidato GetById(int id);
        public SoftSkills_Candidato Add(SoftSkills_Candidato softskillcandidato);
        public SoftSkills_Candidato Update(SoftSkills_Candidato softskillcandidato);
        public SoftSkills_Candidato RemovebyId(int id);
    }
}
