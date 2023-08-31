using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGestionale.Migrations
{
    /// <inheritdoc />
    public partial class GestionaleHR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    IDBenefit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeBenefit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.IDBenefit);
                });

            migrationBuilder.CreateTable(
                name: "Benefit_contratto",
                columns: table => new
                {
                    IDBenefits_Contratto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDBenefit = table.Column<int>(type: "int", nullable: false),
                    IDContratto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit_contratto", x => x.IDBenefits_Contratto);
                });

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    IDCandidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CognomeCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecapitoTelCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodiceFiscaleCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDiNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDStato = table.Column<int>(type: "int", nullable: false),
                    IDProvincia = table.Column<int>(type: "int", nullable: false),
                    IDComune = table.Column<int>(type: "int", nullable: false),
                    IDCitta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.IDCandidato);
                });

            migrationBuilder.CreateTable(
                name: "Colloquio",
                columns: table => new
                {
                    IDColloquio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDipendente = table.Column<int>(type: "int", nullable: false),
                    IDTipoColloquio = table.Column<int>(type: "int", nullable: false),
                    IDSede = table.Column<int>(type: "int", nullable: false),
                    IDCandidato = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valutazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDHardSkill_Candidato = table.Column<int>(type: "int", nullable: false),
                    IDSoftSkills_Candidato = table.Column<int>(type: "int", nullable: false),
                    IDTitolodistudio_Candidato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colloquio", x => x.IDColloquio);
                });

            migrationBuilder.CreateTable(
                name: "Comune",
                columns: table => new
                {
                    IDComune = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comune", x => x.IDComune);
                });

            migrationBuilder.CreateTable(
                name: "Contratto",
                columns: table => new
                {
                    IDContratto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTipologiaContratto = table.Column<int>(type: "int", nullable: false),
                    IDLivelloContrattuale = table.Column<int>(type: "int", nullable: false),
                    IDTipologiaDocumento = table.Column<int>(type: "int", nullable: false),
                    IDBenefits_Contratto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratto", x => x.IDContratto);
                });

            migrationBuilder.CreateTable(
                name: "Dipendente",
                columns: table => new
                {
                    IdDipendente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDipendente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CognomeDipendente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodiceFiscaleDipendente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDSede = table.Column<int>(type: "int", nullable: false),
                    IDContratto = table.Column<int>(type: "int", nullable: false),
                    IDRuolo = table.Column<int>(type: "int", nullable: false),
                    IDHardSkills_Dipendente = table.Column<int>(type: "int", nullable: false),
                    IDTitolidistudio_Dipendente = table.Column<int>(type: "int", nullable: false),
                    IDSoftSkills_Dipendente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendente", x => x.IdDipendente);
                });

            migrationBuilder.CreateTable(
                name: "Hardskills",
                columns: table => new
                {
                    IDHardSkills = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneHardSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeHardSkills = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardskills", x => x.IDHardSkills);
                });

            migrationBuilder.CreateTable(
                name: "Hardskills_candidato",
                columns: table => new
                {
                    IDHardSkill_Candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCandidato = table.Column<int>(type: "int", nullable: false),
                    IDHardSkills = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardskills_candidato", x => x.IDHardSkill_Candidato);
                });

            migrationBuilder.CreateTable(
                name: "Hardskills_dipendente",
                columns: table => new
                {
                    IDHardSkill_Dipendente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDipendente = table.Column<int>(type: "int", nullable: false),
                    IDHardSkills = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardskills_dipendente", x => x.IDHardSkill_Dipendente);
                });

            migrationBuilder.CreateTable(
                name: "Livellocontrattuale",
                columns: table => new
                {
                    IDLivelloContrattuale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneLivelloContrattuale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeLivelloContrattuale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livellocontrattuale", x => x.IDLivelloContrattuale);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    IDProvincia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.IDProvincia);
                });

            migrationBuilder.CreateTable(
                name: "Ruolo",
                columns: table => new
                {
                    IDRuolo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneRuolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeRuolo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruolo", x => x.IDRuolo);
                });

            migrationBuilder.CreateTable(
                name: "Sedi",
                columns: table => new
                {
                    IDSede = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndirizzoSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecapitoTelSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDipendente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedi", x => x.IDSede);
                });

            migrationBuilder.CreateTable(
                name: "Softskills",
                columns: table => new
                {
                    IDSoftSkills = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneSoftSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeSoftSkills = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softskills", x => x.IDSoftSkills);
                });

            migrationBuilder.CreateTable(
                name: "Softskills_candidato",
                columns: table => new
                {
                    IDSoftSkills_Candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCandidato = table.Column<int>(type: "int", nullable: false),
                    IDSoftSkills = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softskills_candidato", x => x.IDSoftSkills_Candidato);
                });

            migrationBuilder.CreateTable(
                name: "Softskills_dipendente",
                columns: table => new
                {
                    IDSoftSkills_Dipendente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDipendente = table.Column<int>(type: "int", nullable: false),
                    IDSoftSkills = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softskills_dipendente", x => x.IDSoftSkills_Dipendente);
                });

            migrationBuilder.CreateTable(
                name: "Stato",
                columns: table => new
                {
                    IDStato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stato", x => x.IDStato);
                });

            migrationBuilder.CreateTable(
                name: "Tipocolloquio",
                columns: table => new
                {
                    IDTipologiacolloquio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipocolloquio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeTipocolloquio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipocolloquio", x => x.IDTipologiacolloquio);
                });

            migrationBuilder.CreateTable(
                name: "Tipocontratto",
                columns: table => new
                {
                    IDTipologiacontratto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipocontratto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeTipocontratto = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipocontratto", x => x.IDTipologiacontratto);
                });

            migrationBuilder.CreateTable(
                name: "Tipodocumento",
                columns: table => new
                {
                    IDTipologiadocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipodocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeTipodocumento = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipodocumento", x => x.IDTipologiadocumento);
                });

            migrationBuilder.CreateTable(
                name: "Titolidistudio",
                columns: table => new
                {
                    IDTitolodistudio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTitolidistudio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeTitolitdistudio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titolidistudio", x => x.IDTitolodistudio);
                });

            migrationBuilder.CreateTable(
                name: "Titolidistudio_candidato",
                columns: table => new
                {
                    IDTitolodistudio_Candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCandidato = table.Column<int>(type: "int", nullable: false),
                    IDTitolodistudio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titolidistudio_candidato", x => x.IDTitolodistudio_Candidato);
                });

            migrationBuilder.CreateTable(
                name: "Titolidistudio_dipendente",
                columns: table => new
                {
                    IDTitolodistudio_Dipendente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDipendente = table.Column<int>(type: "int", nullable: false),
                    IDTitolodistudio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titolidistudio_dipendente", x => x.IDTitolodistudio_Dipendente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "Benefit_contratto");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Colloquio");

            migrationBuilder.DropTable(
                name: "Comune");

            migrationBuilder.DropTable(
                name: "Contratto");

            migrationBuilder.DropTable(
                name: "Dipendente");

            migrationBuilder.DropTable(
                name: "Hardskills");

            migrationBuilder.DropTable(
                name: "Hardskills_candidato");

            migrationBuilder.DropTable(
                name: "Hardskills_dipendente");

            migrationBuilder.DropTable(
                name: "Livellocontrattuale");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Ruolo");

            migrationBuilder.DropTable(
                name: "Sedi");

            migrationBuilder.DropTable(
                name: "Softskills");

            migrationBuilder.DropTable(
                name: "Softskills_candidato");

            migrationBuilder.DropTable(
                name: "Softskills_dipendente");

            migrationBuilder.DropTable(
                name: "Stato");

            migrationBuilder.DropTable(
                name: "Tipocolloquio");

            migrationBuilder.DropTable(
                name: "Tipocontratto");

            migrationBuilder.DropTable(
                name: "Tipodocumento");

            migrationBuilder.DropTable(
                name: "Titolidistudio");

            migrationBuilder.DropTable(
                name: "Titolidistudio_candidato");

            migrationBuilder.DropTable(
                name: "Titolidistudio_dipendente");
        }
    }
}
