using Dapper;
using Microsoft.Extensions.Configuration;
using School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace School.Repository
{
    public class GradeRepository
    {
        public string _connectionString;
        public GradeRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("SchoolDb");
        }
        public IList<Grade> GetGrades()
        {
            var query = "SELECT [GradeId],[StudentId],[CourseId],[Grade] as Mark FROM[School].[dbo].[Grades]";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Grade>(query).ToList();

            }
        }

        public void InsertGrade(Grade grade)
        {
            var query = "INSERT INTO Grades(StudentId, CourseId, Grade) VALUES(@StudentId, @CourseId, @Grade)";

            var queryParams = new
            {
                StudentId = grade.StudentId,
                CourseId = grade.CourseId,
                Grade = grade.Mark
            };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, queryParams);

            }

        }
        public void DeleteGrade(int Id)
        {
            var query = "DELETE FROM Grades WHERE GradeId like " + Id;


            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query);
            }

        }
        public void UpdateGrade(Grade grade)
        {
            var query = "UPDATE Grades SET StudentId = @StudentId, CourseId=@CourseId, Grade = @Grade WHERE GradeId = " + grade.GradeId;


            var queryParams = new
            {
                StudentId = grade.StudentId,
                CourseId = grade.CourseId,
                Grade = grade.Mark
            };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, queryParams);

            }

        }
    }
}
