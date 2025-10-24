using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace school_mvc_dotnet.Models
{
    public class Aluno
    {
        [Key]
        public int id{get;set;}
		[Required]
		[StringLength(60)]
		public string Name{get;set;}
		[Required]
		[StringLength(60)]
		public string LastName{get;set;}
		[Required]
		[Range(12,38)]
		public string Age{get;set;}
		
    }
}