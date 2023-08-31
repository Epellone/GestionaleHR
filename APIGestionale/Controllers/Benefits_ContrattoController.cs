using APIGestionale.Models;
using APIGestionale.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Benefits_ContrattoController : ControllerBase
    {
        private IRepositoryBenefits_Contratto repository;

        public Benefits_ContrattoController(IRepositoryBenefits_Contratto repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Benefits_Contratto> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Benefits_Contratto GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Benefits_Contratto Add([FromBody] Benefits_Contratto benefits_contratto)
        {
            return repository.Add(benefits_contratto);
        }

        [HttpPut]
        public Benefits_Contratto Update([FromBody] Benefits_Contratto benefits_contratto)
        {
            return repository.Update(benefits_contratto);
        }

        [HttpDelete("{id:int}")]
        public Benefits_Contratto RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}


