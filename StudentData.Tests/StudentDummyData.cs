using Student_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Tests
{
    public class StudentDummyData
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                StudentName = "Test1",
                Class = 10,
                Subject = "Computers",
                Marks = 66
            },
            new Student
            {
                StudentName = "Test2",
                Class = 10,
                Subject = "Computers",
                Marks = 60
            },
            new Student
            {
                StudentName = "Test3",
                Class = 10,
                Subject = "Computers",
                Marks = 69
            }
        };
    }
}
