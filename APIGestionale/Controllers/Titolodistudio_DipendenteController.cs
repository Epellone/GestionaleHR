using APIGestionale.Models.Interface;
using APIGestionale.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionale.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Titolodistudio_DipendenteController : ControllerBase
    {
        private IRepositoryTitolodistudio_Dipendente repository;

        public Titolodistudio_DipendenteController(IRepositoryTitolodistudio_Dipendente repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Titolodistudio_Dipendente> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Titolodistudio_Dipendente GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Titolodistudio_Dipendente Add([FromBody] Titolodistudio_Dipendente titolodistudio_dipendente)
        {
            return repository.Add(titolodistudio_dipendente);
        }

        [HttpPut]
        public Titolodistudio_Dipendente Update([FromBody] Titolodistudio_Dipendente titolodistudio_dipendente)
        {
            return repository.Update(titolodistudio_dipendente);
        }

        [HttpDelete("{id:int}")]
        public Titolodistudio_Dipendente RemoveById([FromBody] int id)
        {
            return repository.RemovebyId(id);
        }
    }
}
