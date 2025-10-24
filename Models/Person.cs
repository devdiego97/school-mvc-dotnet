using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace school_mvc_dotnet.Models
{
	public abstract class Person:BaseModel
	{


		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[Range(10,60)]
		public int Age { get; set; }
		[Required]
		[StringLength(20)]
		public string Sex { get; set; }

		
		
	}
}