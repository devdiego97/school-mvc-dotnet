using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using school_mvc_dotnet.Models;


namespace school_mvc_dotnet.Controllers
{
    public class Alunos:Controller
    {
        public IActionResult Index(){
			
			 var produtos = new List<Produto>
			{
				new Produto { Id = 1, Nome = "Teclado", Preco = 120 },
				new Produto { Id = 2, Nome = "Mouse", Preco = 80 },
				new Produto { Id = 3, Nome = "Monitor", Preco = 900 }
			};

			return View(produtos);
				}
			}
}