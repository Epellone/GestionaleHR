namespace APIGestionale.Models.Interface
{
    public interface IRepositoryCandidato
    {
        public List<Candidato> GetAll();
        public Candidato GetById(int id);
        public Candidato Add(Candidato candidato);
        public Candidato Update(Candidato candidato);
        public Candidato RemovebyId(int id);
    }
}
