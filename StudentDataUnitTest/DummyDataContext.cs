using Student_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataUnitTest
{
    public class DummyDataContext
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                StudentName = "Ragav",
                Class=10,
                Subject = "Computers",
                Marks = 89
            },
            new Student
            {
                StudentName = "Ashok",
                Class=10,
                Subject = "Computers",
                Marks = 78
            }
        };
    }
}
