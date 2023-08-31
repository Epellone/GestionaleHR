namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTitolodistudio_Candidato
    {
        public List<Titolodistudio_Candidato> GetAll();
        public Titolodistudio_Candidato GetById(int id);
        public Titolodistudio_Candidato Add(Titolodistudio_Candidato titolodistudio_candidato);
        public Titolodistudio_Candidato Update(Titolodistudio_Candidato titolodistudio_candidato);
        public Titolodistudio_Candidato RemovebyId(int id);
    }
}
