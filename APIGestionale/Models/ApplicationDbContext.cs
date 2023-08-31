using Microsoft.EntityFrameworkCore;


namespace APIGestionale.Models
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } //costruttore di applicationdbcontext che eredita dalla classe base dbncontext con parametro options
        public DbSet<Sede> Sedi { get; set; }
        public DbSet<Benefits> Benefit { get; set; }
        public DbSet<Benefits_Contratto> Benefit_contratto { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Colloquio> Colloquio { get; set; }
        public DbSet<Comune> Comune { get; set; }
        public DbSet<Contratto> Contratto { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Stato> Stato { get; set; }
        public DbSet<Dipendente> Dipendente { get; set; }
        public DbSet<HardSkills> Hardskills { get; set; }
        public DbSet<HardSkill_Candidato> Hardskills_candidato { get; set; }
        public DbSet<HardSkill_Dipendente> Hardskills_dipendente { get; set; }
        public DbSet<SoftSkills> Softskills { get; set; }
        public DbSet<SoftSkills_Dipendente> Softskills_dipendente { get; set; }
        public DbSet<SoftSkills_Candidato> Softskills_candidato { get; set; }
        public DbSet<Livellocontrattuale> Livellocontrattuale { get; set; }
        public DbSet<Ruolo> Ruolo { get; set; }
        public DbSet<Tipologiacolloquio> Tipocolloquio { get; set; }
        public DbSet<Tipologiacontratto> Tipocontratto { get; set; }
        public DbSet<Tipologiadocumento> Tipodocumento { get; set; }
        public DbSet<Titolodistudio_Dipendente> Titolidistudio_dipendente { get; set; }
        public DbSet<Titolodistudio_Candidato> Titolidistudio_candidato { get; set; }
        public DbSet<Titolidistudio> Titolidistudio { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) //metodo che viene richiamato quando viene creato il dbcontext (database), per configurare l'entità (model)
        {
            modelBuilder.Entity<Titolidistudio>()
                .HasKey(p => p.IDTitolodistudio);
            
            modelBuilder.Entity<Titolodistudio_Dipendente>()
                .HasKey(p => p.IDTitolodistudio_Dipendente);
            
            modelBuilder.Entity<Titolodistudio_Candidato>()
                .HasKey(p => p.IDTitolodistudio_Candidato);
   
            modelBuilder.Entity<Stato>()
                .HasKey(p => p.IDStato);

            modelBuilder.Entity<Tipologiadocumento>()
                .HasKey(g => g.IDTipologiadocumento);

            modelBuilder.Entity<Tipologiacontratto>()
                .HasKey(g => g.IDTipologiacontratto);

            modelBuilder.Entity<Tipologiacolloquio>()
                .HasKey(g => g.IDTipologiacolloquio);

            modelBuilder.Entity<Ruolo>()
                .HasKey(g => g.IDRuolo);

            modelBuilder.Entity<Livellocontrattuale>()
                .HasKey(g => g.IDLivelloContrattuale);

            modelBuilder.Entity<HardSkills>()
                .HasKey(g => g.IDHardSkills);

            modelBuilder.Entity<HardSkill_Candidato>()
                .HasKey(g => g.IDHardSkill_Candidato);

            modelBuilder.Entity<HardSkill_Dipendente>()
                 .HasKey(g => g.IDHardSkill_Dipendente);

            modelBuilder.Entity<SoftSkills>()
                .HasKey(g => g.IDSoftSkills);

            modelBuilder.Entity<SoftSkills_Candidato>()
                .HasKey(g => g.IDSoftSkills_Candidato);

            modelBuilder.Entity<SoftSkills_Dipendente>()
                .HasKey(g => g.IDSoftSkills_Dipendente);

            modelBuilder.Entity<Dipendente>()
                .HasKey(g => g.IdDipendente);

            modelBuilder.Entity<Contratto>()
                .HasKey(g => g.IDContratto);

            modelBuilder.Entity<Comune>()
                .HasKey(g => g.IDComune);

            modelBuilder.Entity<Colloquio>()
                .HasKey(g => g.IDColloquio);

            modelBuilder.Entity<Candidato>()
                .HasKey(g => g.IDCandidato);

            modelBuilder.Entity<Benefits>()
                .HasKey(g => g.IDBenefit);
            
            modelBuilder.Entity<Benefits_Contratto>()
                .HasKey(g => g.IDBenefits_Contratto);

            modelBuilder.Entity<Sede>()
                .HasKey(g => g.IDSede);
            
            modelBuilder.Entity<Provincia>()
                .HasKey(g => g.IDProvincia);

        }
    }
}
