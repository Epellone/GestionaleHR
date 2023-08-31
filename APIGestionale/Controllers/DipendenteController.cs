using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DipendenteController : ControllerBase
    {
        private IRepositoryDipendente repository;

        public DipendenteController(IRepositoryDipendente repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Dipendente> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Dipendente GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Dipendente Add([FromBody] Dipendente dipendente)
        {
            return repository.Add(dipendente);
        }

        [HttpPut]
        public Dipendente Update([FromBody] Dipendente dipendente)
        {
            return repository.Update(dipendente);
        }

        [HttpDelete("{id:int}")]
        public Dipendente RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
