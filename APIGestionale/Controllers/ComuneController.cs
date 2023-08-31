using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComuneController : ControllerBase
    {
        private IRepositoryComune repository;

        public ComuneController(IRepositoryComune repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Comune> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Comune GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Comune Add([FromBody] Comune comune)
        {
            return repository.Add(comune);
        }

        [HttpPut]
        public Comune Update([FromBody] Comune comune)
        {
            return repository.Update(comune);
        }

        [HttpDelete("{id:int}")]
        public Comune RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
