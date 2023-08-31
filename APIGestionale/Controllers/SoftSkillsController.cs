using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SoftSkillsController : ControllerBase
    {
        private IRepositorySoftSkills repository;

        public SoftSkillsController(IRepositorySoftSkills repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<SoftSkills> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public SoftSkills GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public SoftSkills Add([FromBody] SoftSkills softskills)
        {
            return repository.Add(softskills);
        }

        [HttpPut]
        public SoftSkills Update([FromBody] SoftSkills softskills)
        {
            return repository.Update(softskills);
        }

        [HttpDelete("{id:int}")]
        public SoftSkills RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
