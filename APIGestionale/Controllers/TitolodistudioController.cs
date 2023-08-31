using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TitolodistudioController : ControllerBase
    {
        private IRepositoryTitolodistudio repository;

        public TitolodistudioController(IRepositoryTitolodistudio repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Titolidistudio> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Titolidistudio GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Titolidistudio Add([FromBody] Titolidistudio titolodistudio)
        {
            return repository.Add(titolodistudio);
        }

        [HttpPut]
        public Titolidistudio Update([FromBody] Titolidistudio titolodistudio)
        {
            return repository.Update(titolodistudio);
        }

        [HttpDelete("{id:int}")]
        public Titolidistudio RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
