using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private IRepositoryCandidato repository;

        public CandidatoController(IRepositoryCandidato repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Candidato> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Candidato GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Candidato Add([FromBody] Candidato candidato)
        {
            return repository.Add(candidato);
        }

        [HttpPut]
        public Candidato Update([FromBody] Candidato candidato)
        {
            return repository.Update(candidato);
        }

        [HttpDelete("{id:int}")]
        public Candidato RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
