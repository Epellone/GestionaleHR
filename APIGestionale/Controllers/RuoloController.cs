using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RuoloController : ControllerBase
    {
        private IRepositoryRuolo repository;

        public RuoloController(IRepositoryRuolo repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Ruolo> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Ruolo GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Ruolo Add([FromBody] Ruolo ruolo)
        {
            return repository.Add(ruolo);
        }

        [HttpPut]
        public Ruolo Update([FromBody] Ruolo ruolo)
        {
            return repository.Update(ruolo);
        }

        [HttpDelete("{id:int}")]
        public Ruolo RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
