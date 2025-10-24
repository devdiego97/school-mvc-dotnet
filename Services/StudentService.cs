using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_mvc_dotnet.Database;
using school_mvc_dotnet.Dtos;
using school_mvc_dotnet.Models;

namespace school_mvc_dotnet.Services
{
    public class StudentService
    {
		private readonly AppDbContext _database;

		public StudentService(AppDbContext database)
		{
			_database = database;
		}

		private static StudentDTO ToDTO(Student s) => new(s.Id, s.Name, s.LastName, s.Sex, s.Age, s.Email);


		public async Task<List<StudentDTO>> GelAllAsync() =>
			  await _database.Students.Select(d => new StudentDTO(d.Id, d.Name, d.LastName, d.Sex, d.Age, d.Email)).ToListAsync();
		
		public async Task<StudentDTO?> GetStudentById(int Id)
		{
			var student = await _database.Students.FindAsync(Id);
			if (student is null) return null;
			return ToDTO(student);

			
		}

		public async Task<(bool ok, string message, int? id)> CreateNewStudent(StudentDTO data)
		{
			var student = new Student { Name = data.Name, LastName = data.LastName, Sex = data.Sex, Age = data.Age, Email = data.Email };
			_database.Students.Add(student);
			await _database.SaveChangesAsync();
			return (true, $"Aluno '{student.Name}' criado.", student.Id);
		}

		public async Task<(bool ok, string message)> UpdatedStudent(int Id, StudentUpdateDTO dataUpdate)
		{
			var studentId = await _database.Students.FindAsync(Id);
			if (studentId is null) return (false, $"Aluno id {Id} não encontrado.");

			studentId.Name = dataUpdate.Name;
			studentId.Age = dataUpdate.Age;
			studentId.LastName = dataUpdate.LastName;
			studentId.Email = dataUpdate.Email;

			await _database.SaveChangesAsync();
			return (true, $"Aluno id {Id} não encontrado.");

		}
		
		public async Task <(bool ok, string message)> DeleteStudent(int  Id)
		{
			var studentId = await _database.Students.FindAsync(Id);
			if (studentId is null) return (false, $"Aluno id {Id} não encontrado.");

			_database.Students.Remove(studentId);
			await _database.SaveChangesAsync();
			 return (true, $"Aluno '{studentId.Name}' removido.");


		}
    }
}