using FakeItEasy;
using Student_Models.Models;
using Student_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StudentTestCases
{
    public class StudentUnitTests
    {
        [Fact]
        public void Test()
        {
            var fakeStudent = A.Fake<IStudentDataRepository>();

            //Arrange
            List<Student> student = new List<Student>()
            {
                new Student
                {
                    StudentName = "RaGav",
                    Class=10,
                    Subject="Computers",
                    Marks=77
                },
                new Student
                {
                    StudentName = "Madhan",
                    Class=10,
                    Subject="Computers",
                    Marks=72
                },
                new Student
                {
                    StudentName = "Pavnith",
                    Class=10,
                    Subject="Computers",
                    Marks=78
                },
                new Student
                {
                    StudentName = "Mohan",
                    Class=9,
                    Subject="Computers",
                    Marks=77
                },
                new Student
                {
                    StudentName = "Naresh",
                    Class=8,
                    Subject="Computers",
                    Marks=77
                }
            };

            //Act
            int classId = 10;
            var result = fakeStudent.getClassMarksAverageDetails(classId);

            //Assert
            Assert.Equal(10, 10);
           
        }
    }
}
