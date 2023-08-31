using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SedeController : ControllerBase
    {
        private IRepositorySede repository;

        public SedeController(IRepositorySede repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Sede> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Sede GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Sede Add([FromBody] Sede sede)
        {
            return repository.Add(sede);
        }

        [HttpPut]
        public Sede Update([FromBody] Sede sede)
        {
            return repository.Update(sede);
        }

        [HttpDelete("{id:int}")]
        public Sede RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
