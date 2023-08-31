using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using APIGestionale.Models;
using APIGestionale.Models.Interface;
using System;

namespace GestionaleHR.Pages
{
    public class AnagraficaSediModel : PageModel
    {
        private static HttpClient client = new()
        {
            BaseAddress = new Uri("https://localhost:7164")
        };
        private string Uri = "api/Sede"; // Assicurati che il percorso API sia corretto

        public List<Sede> Lista { get; set; }

        public AnagraficaSediModel() // Assicurati di iniettare il repositorySede corretto
        { 
            Lista = new List<Sede>();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Lista = await client.GetFromJsonAsync<List<Sede>>(Uri); // Recupera la lista di sedi dal repository
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach (var sede in Lista)
            {
                await client.PutAsJsonAsync<Sede>($"{Uri}/{sede.IDSede}", sede);
            }

            return RedirectToPage("/AnagraficaSedi"); // Assicurati di avere il percorso corretto
        }
    }
}


