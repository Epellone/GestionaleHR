using APIGestionale.Models.Interface;

namespace APIGestionale.Models.Repository
{
    public class RepositoryTitolodistudio_Dipendente : IRepositoryTitolodistudio_Dipendente
    {

        private ApplicationDbContext dbtitolodistudio_dipendente;

        public RepositoryTitolodistudio_Dipendente(ApplicationDbContext dbcontext)
        {
            this.dbtitolodistudio_dipendente = dbcontext;
        }

        public List<Titolodistudio_Dipendente> GetAll()
        {
            return dbtitolodistudio_dipendente.Titolidistudio_dipendente.ToList();
        }

        public Titolodistudio_Dipendente GetById(int id)
        {
            return dbtitolodistudio_dipendente.Titolidistudio_dipendente.Where(a => a.IDTitolodistudio_Dipendente == id).SingleOrDefault();
        }

        public Titolodistudio_Dipendente Add(Titolodistudio_Dipendente titolodistudio_dipendente)
        {
            var add = dbtitolodistudio_dipendente.Titolidistudio_dipendente.Add(titolodistudio_dipendente);
            dbtitolodistudio_dipendente.SaveChanges();
            return add.Entity;
        }

        public Titolodistudio_Dipendente Update(Titolodistudio_Dipendente titolodistudio_dipendente)
        {
            var update = dbtitolodistudio_dipendente.Titolidistudio_dipendente.Update(titolodistudio_dipendente);
            dbtitolodistudio_dipendente.SaveChanges();
            return update.Entity;
        }

        public Titolodistudio_Dipendente RemovebyId(int id)
        {
            var remove = dbtitolodistudio_dipendente.Titolidistudio_dipendente.Remove(GetById(id));
            dbtitolodistudio_dipendente.SaveChanges();
            return remove.Entity;
        }
    }
}
