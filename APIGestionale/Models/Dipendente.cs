namespace APIGestionale.Models
{
    public class Dipendente
    {
        public int IdDipendente { get; set; }
        public string NomeDipendente { get; set; }
        public string CognomeDipendente { get; set; }
        public string CodiceFiscaleDipendente { get; set; }
        public int IDSede { get; set; }
        public int IDContratto { get; set; }
        public int IDRuolo { get; set; }
        public int IDHardSkills_Dipendente { get; set; }
        public int IDTitolidistudio_Dipendente { get; set; }
        public int IDSoftSkills_Dipendente { get; set; }

    }
}
