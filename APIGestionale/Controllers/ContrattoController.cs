using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContrattoController : ControllerBase
    {
        private IRepositoryContratto repository;

        public ContrattoController(IRepositoryContratto repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Contratto> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Contratto GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Contratto Add([FromBody] Contratto contratto)
        {
            return repository.Add(contratto);
        }

        [HttpPut]
        public Contratto Update([FromBody] Contratto contratto)
        {
            return repository.Update(contratto);
        }

        [HttpDelete("{id:int}")]
        public Contratto RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
