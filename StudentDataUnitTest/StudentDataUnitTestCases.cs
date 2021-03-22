using FakeItEasy;
using Student_Models.Models;
using Student_Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace StudentDataUnitTest
{
    public class StudentDataUnitTestCases
    {
        private readonly IStudentDataRepository _sut;
        public StudentDataUnitTestCases(IStudentDataRepository sut)
        {
            _sut = sut;
        }
        [Fact]
        public void AddStudent_StudentObject_ShouldReturn()
        {
            var obj = new Student { StudentName = "Test", Marks = 70, Subject = "Computers", Class = 10 };
            var stdObject = A.Fake<List<Student>>();
            var sdr = A.Fake<IStudentDataRepository>();
            var result = _sut.addStudentDetails(obj);
        }
    }
}
