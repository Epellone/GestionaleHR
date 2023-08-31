using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TipologiacontrattoController : ControllerBase
    {
        private IRepositoryTipologiaContratto repository;

        public TipologiacontrattoController(IRepositoryTipologiaContratto repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Tipologiacontratto> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Tipologiacontratto GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Tipologiacontratto Add([FromBody] Tipologiacontratto tipoconratto)
        {
            return repository.Add(tipoconratto);
        }

        [HttpPut]
        public Tipologiacontratto Update([FromBody] Tipologiacontratto tipocontratto)
        {
            return repository.Update(tipocontratto);
        }

        [HttpDelete("{id:int}")]
        public Tipologiacontratto RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
