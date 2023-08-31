namespace APIGestionale.Models.Interface
{
    public interface IRepositoryTitolodistudio_Dipendente
    {
        public List<Titolodistudio_Dipendente> GetAll();
        public Titolodistudio_Dipendente GetById(int id);
        public Titolodistudio_Dipendente Add(Titolodistudio_Dipendente titolodistudio_dipendente);
        public Titolodistudio_Dipendente Update(Titolodistudio_Dipendente titolodistudio_dipendente);
        public Titolodistudio_Dipendente RemovebyId(int id);
    }
}
