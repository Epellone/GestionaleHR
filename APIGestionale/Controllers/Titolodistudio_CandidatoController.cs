using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Titolodistudio_CandidatoController : ControllerBase
    {
        private IRepositoryTitolodistudio_Candidato repository;

        public Titolodistudio_CandidatoController(IRepositoryTitolodistudio_Candidato repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Titolodistudio_Candidato> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Titolodistudio_Candidato GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Titolodistudio_Candidato Add([FromBody] Titolodistudio_Candidato titolodistudio_candidato)
        {
            return repository.Add(titolodistudio_candidato);
        }

        [HttpPut]
        public Titolodistudio_Candidato Update([FromBody] Titolodistudio_Candidato titolodistudio_candidato)
        {
            return repository.Update(titolodistudio_candidato);
        }

        [HttpDelete("{id:int}")]
        public Titolodistudio_Candidato RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
