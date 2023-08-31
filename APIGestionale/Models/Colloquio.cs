namespace APIGestionale.Models
{
    public class Colloquio
    {
        public int IDColloquio { get; set; }
        public int IDDipendente { get; set; } //per HR e referente 
        public int IDTipoColloquio { get; set; }
        public int IDSede { get; set; }
        public int IDCandidato { get; set; }
        public DateTime Data { get; set; }
        public string Valutazione { get; set; }
        public string Note { get; set; }
        public int IDHardSkill_Candidato { get; set; }
        public int IDSoftSkills_Candidato { get; set; }
        public int IDTitolodistudio_Candidato { get; set; }
    }
}

