using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HardSkills_DipendenteController : ControllerBase
    {
        private IRepositoryHardSkills_Dipendente repository;

        public HardSkills_DipendenteController(IRepositoryHardSkills_Dipendente repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<HardSkill_Dipendente> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public HardSkill_Dipendente GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public HardSkill_Dipendente Add([FromBody] HardSkill_Dipendente hardskill_dipendente)
        {
            return repository.Add(hardskill_dipendente);
        }

        [HttpPut]
        public HardSkill_Dipendente Update([FromBody] HardSkill_Dipendente hardskill_dipendente)
        {
            return repository.Update(hardskill_dipendente);
        }

        [HttpDelete("{id:int}")]
        public HardSkill_Dipendente RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
