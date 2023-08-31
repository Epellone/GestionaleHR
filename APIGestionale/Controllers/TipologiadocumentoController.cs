using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TipologiadocumentoController : ControllerBase
    {
        private IRepositoryTipologiaDocumento repository;

        public TipologiadocumentoController(IRepositoryTipologiaDocumento repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Tipologiadocumento> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Tipologiadocumento GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Tipologiadocumento Add([FromBody] Tipologiadocumento tipologiadocumento)
        {
            return repository.Add(tipologiadocumento);
        }

        [HttpPut]
        public Tipologiadocumento Update([FromBody] Tipologiadocumento tipologiadocumento)
        {
            return repository.Update(tipologiadocumento);
        }

        [HttpDelete("{id:int}")]
        public Tipologiadocumento RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
