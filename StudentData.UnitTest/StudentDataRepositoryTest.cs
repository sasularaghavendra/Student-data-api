using FakeItEasy;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Student_Models.Models;
using Student_Repository;
using Student_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StudentData.UnitTest
{
    public class StudentDataRepositoryTest
    {
        private readonly IStudentData _studentData;
        private readonly IStudentDataRepository _studentDataRepository;
        public StudentDataRepositoryTest()
        {
            _studentDataRepository = A.Fake<IStudentDataRepository>();
            _studentData = new Student_Services.StudentData(_studentDataRepository);
        }
        [Fact]
        public async void Repository_AddStudent()
        {

        }
    }
}
