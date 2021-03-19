using Microsoft.EntityFrameworkCore;
using Student_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Repository.DbConnection_PostgreSQL
{
    public class StudentDatabaseContext : DbContext
    {
        public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
