using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LivelloContrattualeController : ControllerBase
    {
        private IRepositoryLivelloContrattuale repository;

        public LivelloContrattualeController(IRepositoryLivelloContrattuale repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Livellocontrattuale> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Livellocontrattuale GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Livellocontrattuale Add([FromBody] Livellocontrattuale livellocontrattuale)
        {
            return repository.Add(livellocontrattuale);
        }

        [HttpPut]
        public Livellocontrattuale Update([FromBody] Livellocontrattuale livellocontrattuale)
        {
            return repository.Update(livellocontrattuale);
        }

        [HttpDelete("{id:int}")]
        public Livellocontrattuale RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
