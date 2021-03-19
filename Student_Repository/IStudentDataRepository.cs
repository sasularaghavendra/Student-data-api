using Student_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Repository
{
    public interface IStudentDataRepository
    {
        Task<ServiceResponse<Student>> addStudentDetails(Student student);
        ServiceResponse<double> getClassMarksAverageDetails(int classId);
    }
}
