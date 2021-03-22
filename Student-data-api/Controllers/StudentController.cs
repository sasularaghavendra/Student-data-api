using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Models.Models;
using Student_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_data_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentData _studentData;
        public StudentController(IStudentData studentData)
        {
            _studentData = studentData;
        }
        [HttpPost("addStudentDetails")]
        public async Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            return await _studentData.addStudentDetails(student);
        }
        [HttpGet("getClassAverageMarks")]
        public ServiceResponse<double> getClassMarksAverageDetails(int classId)
        {
            return _studentData.getClassMarksAverageDetails(classId);
        }
    }
}
