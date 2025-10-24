using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_mvc_dotnet.Models;

namespace school_mvc_dotnet.Database
{
    public class AppDbContext:DbContext
	
	
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
		public DbSet<Aluno> Alunos{get;set;}
    }
}