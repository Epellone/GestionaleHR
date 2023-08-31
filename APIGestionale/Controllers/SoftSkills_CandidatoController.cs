using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SoftSkills_CandidatoController : ControllerBase
    {
        private IRepositorySoftSkills_Candidato repository;

        public SoftSkills_CandidatoController(IRepositorySoftSkills_Candidato repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<SoftSkills_Candidato> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public SoftSkills_Candidato GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public SoftSkills_Candidato Add([FromBody] SoftSkills_Candidato softskills_candidato)
        {
            return repository.Add(softskills_candidato);
        }

        [HttpPut]
        public SoftSkills_Candidato Update([FromBody] SoftSkills_Candidato softskills_candidato)
        {
            return repository.Update(softskills_candidato);
        }

        [HttpDelete("{id:int}")]
        public SoftSkills_Candidato RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
