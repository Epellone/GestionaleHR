using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HardSkillsController : ControllerBase
    {
        private IRepositoryHardSkills repository;

        public HardSkillsController(IRepositoryHardSkills repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<HardSkills> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public HardSkills GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public HardSkills Add([FromBody] HardSkills hardskills)
        {
            return repository.Add(hardskills);
        }

        [HttpPut]
        public HardSkills Update([FromBody] HardSkills hardskills)
        {
            return repository.Update(hardskills);
        }

        [HttpDelete("{id:int}")]
        public HardSkills RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
