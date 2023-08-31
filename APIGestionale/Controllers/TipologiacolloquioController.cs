using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;


namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TipologiacolloquioController : ControllerBase
    {
        private IRepositoryTipologiaColloquio repository;

        public TipologiacolloquioController(IRepositoryTipologiaColloquio repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Tipologiacolloquio> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Tipologiacolloquio GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Tipologiacolloquio Add([FromBody] Tipologiacolloquio tipocolloquio)
        {
            return repository.Add(tipocolloquio);
        }

        [HttpPut]
        public Tipologiacolloquio Update([FromBody] Tipologiacolloquio tipocolloquio)
        {
            return repository.Update(tipocolloquio);
        }

        [HttpDelete("{id:int}")]
        public Tipologiacolloquio RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
