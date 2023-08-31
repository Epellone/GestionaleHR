namespace APIGestionale.Models
{
    public class Candidato
    {
        public int IDCandidato { get; set; }
        public string NomeCandidato { get; set; }
        public string CognomeCandidato { get; set; }
        public string RecapitoTelCandidato { get; set; }
        public string CodiceFiscaleCandidato { get; set; } 
        public string EmailCandidato { get; set; }
        public DateTime DataDiNascita { get; set; }
        public int IDStato { get; set; }
        public int IDProvincia { get; set; }
        public int IDComune { get; set; }
        public int IDCitta { get; set; }

    }
}
