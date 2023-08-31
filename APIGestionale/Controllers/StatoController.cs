using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StatoController : ControllerBase
    {
        private IRepositoryStato repository;

        public StatoController(IRepositoryStato repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Stato> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Stato GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Stato Add([FromBody] Stato stato)
        {
            return repository.Add(stato);
        }

        [HttpPut]
        public Stato Update([FromBody] Stato stato)
        {
            return repository.Update(stato);
        }

        [HttpDelete("{id:int}")]
        public Stato RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
