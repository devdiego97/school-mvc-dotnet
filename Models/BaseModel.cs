using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_mvc_dotnet.Models
{
    public class BaseModel
    {
		[Key]
		public int Id { get; set; }
		public DateTime createdAt { get; set; } = DateTime.UtcNow;
		public DateTime? updatedAT{ get; set; }
    }
}