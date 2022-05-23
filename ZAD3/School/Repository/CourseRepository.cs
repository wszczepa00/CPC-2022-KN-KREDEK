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
    public class CourseRepository
    {
        public string _connectionString;
        public CourseRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("SchoolDb");
        }
        public IList<Course> GetCourses()
        {
            var query = "SELECT [CourseId],[Name],[Ects] FROM[School].[dbo].[Courses]";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Course>(query).ToList();

            }
        }
    }
}
