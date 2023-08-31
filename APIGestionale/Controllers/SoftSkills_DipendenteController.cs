using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SoftSkills_DipendenteController : ControllerBase
    {
        private IRepositorySoftSkills_Dipendente repository;

        public SoftSkills_DipendenteController(IRepositorySoftSkills_Dipendente repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<SoftSkills_Dipendente> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public SoftSkills_Dipendente GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public SoftSkills_Dipendente Add([FromBody] SoftSkills_Dipendente softskills_dipendente)
        {
            return repository.Add(softskills_dipendente);
        }

        [HttpPut]
        public SoftSkills_Dipendente Update([FromBody] SoftSkills_Dipendente softskills_dipendente)
        {
            return repository.Update(softskills_dipendente);
        }

        [HttpDelete("{id:int}")]
        public SoftSkills_Dipendente RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
