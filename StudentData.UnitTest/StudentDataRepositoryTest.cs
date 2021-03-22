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
            //Arrange
            ServiceResponse<Student> serviceResponse = new ServiceResponse<Student>
            {
                Data = new Student
                {
                    StudentId = 7,
                    StudentName = "Test",
                    Class = 7,
                    Subject = "Test",
                    Marks = 77
                }             
            };

            //Act   
            A.CallTo(() => _studentDataRepository.addStudentDetails(A<Student>.Ignored)).Returns(serviceResponse);
            ServiceResponse<Student> StudentDetails = await _studentData.addStudentDetails(serviceResponse.Data);

            //Assert
            Assert.Equal(StudentDetails,serviceResponse);
        }
        [Fact]
        public void Repository_getClassAverageMarks()
        {
            //Arrange
            List<Student> students = new List<Student>
            {
                 // StudentId, StudentName, Class, Subject, Marks
                new Student {StudentId = 1, StudentName = "Ragav", Class=10, Subject="Computers",Marks=89},
                new Student {StudentId = 2, StudentName = "Charan", Class=10, Subject ="Computers", Marks=90},
                new Student {StudentId = 3, StudentName = "Arjun", Class=10, Subject="Computers",Marks=79},
                new Student {StudentId = 4, StudentName = "Pavan", Class=10, Subject="Computers",Marks=83},
                new Student {StudentId = 5, StudentName = "Sudarshan", Class=8, Subject="Computers",Marks=77},
                new Student {StudentId = 6, StudentName = "Krish", Class=9, Subject="Computers",Marks=89}

            };
            int classId = 10;
            var studentsList = students.Where(x => x.Class == 10).ToList();
            int studentsCount = studentsList.Count();
            int totalClassMarks = studentsList.Sum(x => x.Marks);
            ServiceResponse<double> serviceResponse = new ServiceResponse<double>
            {
                Data = (totalClassMarks / studentsCount)
            };

            //Act
            A.CallTo(() => _studentDataRepository.getClassMarksAverageDetails(classId)).Returns(serviceResponse);
            ServiceResponse<double> classAverageMarks = _studentData.getClassMarksAverageDetails(classId);

            //Assert
            Assert.Equal(classAverageMarks,serviceResponse);
        }
    }
}
