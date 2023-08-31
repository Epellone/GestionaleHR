using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;
using APIGestionale.Models.Repository;

namespace APIGestionale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColloquioController : ControllerBase
    {
        private IRepositoryColloquio repository;

        public ColloquioController(IRepositoryColloquio repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Colloquio> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Colloquio GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Colloquio Add([FromBody] Colloquio colloquio)
        {
            return repository.Add(colloquio);
        }

        [HttpPut]
        public Colloquio Update([FromBody] Colloquio colloquio)
        {
            return repository.Update(colloquio);
        }

        [HttpDelete("{id:int}")]
        public Colloquio RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
