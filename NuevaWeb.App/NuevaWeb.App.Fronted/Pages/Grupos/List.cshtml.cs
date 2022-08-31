using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NuevaWeb.App.Fronted.Pages
{
    public class ListModel : PageModel
    {

        private string[] grupos = {"Grupo 1", "Grupo 2", "Grupo 3", "Grupo 4"};

        public List<string> GruposMision {get;set;}

        public void OnGet()
        {
            GruposMision = new List<string>();
            GruposMision.AddRange(grupos);
        }
    }
}
