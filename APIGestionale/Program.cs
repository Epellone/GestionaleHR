using APIGestionale.Models;
using APIGestionale.Models.Interface;
using APIGestionale.Models.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetValue<string>("Data:APIGestionale:ConnectionString")));
builder.Services.AddTransient<IRepositoryBenefits, RepositoryBenefits>();
builder.Services.AddTransient<IRepositoryBenefits_Contratto, RepositoryBenefits_Contratto>();
builder.Services.AddTransient<IRepositoryCandidato, RepositoryCandidato>();
builder.Services.AddTransient<IRepositoryColloquio, RepositoryColloquio>();
builder.Services.AddTransient<IRepositoryComune, RepositoryComune>();
builder.Services.AddTransient<IRepositoryContratto, RepositoryContratto>();
builder.Services.AddTransient<IRepositoryDipendente, RepositoryDipendente>();
builder.Services.AddTransient<IRepositoryHardSkills, RepositoryHardSkill>();
builder.Services.AddTransient<IRepositoryHardSkills_Candidato, RepositoryHardSkill_Candidato>();
builder.Services.AddTransient<IRepositoryHardSkills_Dipendente, RepositoryHardSkill_Dipendente>();
builder.Services.AddTransient<IRepositoryLivelloContrattuale, RepositoryLivelloContrattuale>();
builder.Services.AddTransient<IRepositoryProvincia, RepositoryProvincia>();
builder.Services.AddTransient<IRepositoryRuolo, RepositoryRuolo>();
builder.Services.AddTransient<IRepositorySede, RepositorySedi>();
builder.Services.AddTransient<IRepositorySoftSkills, RepositorySoftsSkills>();
builder.Services.AddTransient<IRepositorySoftSkills_Candidato, RepositorySoftSkill_Candidato>();
builder.Services.AddTransient<IRepositorySoftSkills_Dipendente, RepositorySoftSkill_Dipendente>();
builder.Services.AddTransient<IRepositoryStato, RepositoryStato>();
builder.Services.AddTransient<IRepositoryTipologiaColloquio, RepositoryTipologiaColloquio>();
builder.Services.AddTransient<IRepositoryTipologiaContratto, RepositoryTipologiaContratto>();
builder.Services.AddTransient<IRepositoryTipologiaDocumento, RepositoryTipologiaDocumento>();
builder.Services.AddTransient<IRepositoryTitolodistudio, RepositoryTitolodistudio>();
builder.Services.AddTransient<IRepositoryTitolodistudio_Candidato, RepositoryTitolodistudio_Candidato>();
builder.Services.AddTransient<IRepositoryTitolodistudio_Dipendente, RepositoryTitolodistudio_Dipendente>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
