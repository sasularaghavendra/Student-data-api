using FakeItEasy;
using Student_Models.Models;
using Student_Repository;
using Student_Repository.DbConnection_PostgreSQL;
using Student_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTestData
{
    public class StudentDataRepositoryMocker
    {
        public static IStudentDataRepository CreateStudentRepositoryWithMockedStudentTbl()
        {
            IQueryable<Student> data = null;
            StudentDatabaseContext dbContextFactory = A.Fake<StudentDatabaseContext>();
            StudentDatabaseContext dbcontext = FakeDbContext.Fake<StudentDatabaseContext>();
            A.CallTo(() => dbContextFactory).Returns(dbcontext);
           
            data = new List<Student>
            {
                // StudentId, StudentName, Class, Subject, Marks
                new Student {StudentId = 1, StudentName = "Ragav", Class=10, Subject="Computers",Marks=89},
                new Student {StudentId = 2, StudentName = "Charan", Class=10, Subject ="Computers", Marks=90},
                new Student {StudentId = 3, StudentName = "Arjun", Class=10, Subject="Computers",Marks=79},
                new Student {StudentId = 4, StudentName = "Pavan", Class=10, Subject="Computers",Marks=83},
                new Student {StudentId = 5, StudentName = "Sudarshan", Class=8, Subject="Computers",Marks=77},
                new Student {StudentId = 6, StudentName = "Krish", Class=9, Subject="Computers",Marks=89}

            }.AsQueryable();

            dbcontext.MockData(data.ToList(), () => dbcontext.Students);

            return new StudentDataRepository(dbContextFactory);
        }
    }
}