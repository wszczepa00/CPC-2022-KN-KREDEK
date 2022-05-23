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
    public class StudentRepository
    {

        public string _connectionString;
        public StudentRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("SchoolDb");
        }
        public IList<Student> GetStudents()
        {
            var query = "SELECT [StudentId],[Name],[LastName],[Field],[Index] FROM[School].[dbo].[Students]";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Student>(query).ToList();

            }
        }
    }
}
