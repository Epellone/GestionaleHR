namespace APIGestionale.Models.Interface
{
    public interface IRepositorySoftSkills_Dipendente
    {
        public List<SoftSkills_Dipendente> GetAll();
        public SoftSkills_Dipendente GetById(int id);
        public SoftSkills_Dipendente Add(SoftSkills_Dipendente softskilldipendente);
        public SoftSkills_Dipendente Update(SoftSkills_Dipendente softskilldipendente);
        public SoftSkills_Dipendente RemovebyId(int id);
    }
}
