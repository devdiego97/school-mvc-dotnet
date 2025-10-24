using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using school_mvc_dotnet.Models;
using school_mvc_dotnet.Database;


namespace school_mvc_dotnet.Controllers
{
	public class AlunosController : Controller
	{

		private AppDbContext _context;
     	public AlunosController(AppDbContext context)
		{
			_context = context;
		 }

		public IActionResult Index()
		{
			var students = _context.Students.ToList<Student>();
			return View(students);

		}
        
		
		
	
	}
}