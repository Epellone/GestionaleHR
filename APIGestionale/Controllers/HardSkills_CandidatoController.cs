using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HardSkills_CandidatoController : ControllerBase
    {
        private IRepositoryHardSkills_Candidato repository;

        public HardSkills_CandidatoController(IRepositoryHardSkills_Candidato repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<HardSkill_Candidato> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public HardSkill_Candidato GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public HardSkill_Candidato Add([FromBody] HardSkill_Candidato hardskill_candidato)
        {
            return repository.Add(hardskill_candidato);
        }

        [HttpPut]
        public HardSkill_Candidato Update([FromBody] HardSkill_Candidato hardskill_candidato)
        {
            return repository.Update(hardskill_candidato);
        }

        [HttpDelete("{id:int}")]
        public HardSkill_Candidato RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
