using FakeItEasy;
using Student_Models.Models;
using Student_Repository;
using System;
using Xunit;

namespace StudentData.Tests
{
    public class StudentUnitTestCases
    {
        [Fact]
        public void AddStudentData_ValidData_ShouldReturnStudent()
        {
            var obj = new Student { StudentName = "Test4", Subject = "Computers", Class = 9, Marks = 23 };

            var fakeObj = A.Fake<IStudentDataRepository>();

        }
    }
}
