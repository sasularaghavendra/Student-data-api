using Student_Models.Models;
using Student_Repository;
using System;
using System.Threading.Tasks;


namespace Student_Services
{
    public class StudentData : IStudentData
    {
        private readonly IStudentDataRepository _studentDataRepository;
        public StudentData(IStudentDataRepository studentDataRepository)
        {
            _studentDataRepository = studentDataRepository;
        }
        public async Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            return await _studentDataRepository.addStudentDetails(student);
        }

        public ServiceResponse<double> getClassMarksAverageDetails(int classId)
        {
            return _studentDataRepository.getClassMarksAverageDetails(classId);
        }
    }
}
