using APIGestionale.Models;
using APIGestionale.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsController : ControllerBase
    {
        private IRepositoryBenefits repository;

        public BenefitsController(IRepositoryBenefits repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Benefits> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Benefits GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Benefits Add([FromBody] Benefits appuntamenti)
        {
            return repository.Add(appuntamenti);
        }

        [HttpPut]
        public Benefits Update([FromBody] Benefits appuntamenti)
        {
            return repository.Update(appuntamenti);
        }

        [HttpDelete("{id:int}")]
        public Benefits RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
