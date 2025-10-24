using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using school_mvc_dotnet.Models;

namespace school_mvc_dotnet.Dtos
{
	public sealed record StudentDTO(
		  int Id,
	   string Name,
		string LastName,
		string Sex,
	   int Age,
	  string Email
	);




	public sealed record CreateStudentDTO(
		[property: Required, StringLength(50)] string Name,
		[property:Required,StringLength(50)] string LastName,
		[property: Required, EmailAddress] string Email,
		[property: Range(10, 60)] int Age,
		[property: Required] string Sex
	);

	public sealed record StudentUpdateDTO(
		[property: Required, StringLength(50)] string Name,
		[property:Required,StringLength(50)] string LastName,
		[property: Required, EmailAddress] string Email,
		[property: Range(10, 60)] int Age,
		[property: Required] string Sex
);

}