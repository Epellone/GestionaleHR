using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private IRepositoryProvincia repository;

        public ProvinciaController(IRepositoryProvincia repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Provincia> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Provincia GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Provincia Add([FromBody] Provincia provincia)
        {
            return repository.Add(provincia);
        }

        [HttpPut]
        public Provincia Update([FromBody] Provincia provincia)
        {
            return repository.Update(provincia);
        }

        [HttpDelete("{id:int}")]
        public Provincia RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
