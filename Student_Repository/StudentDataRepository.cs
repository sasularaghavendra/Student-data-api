using Student_Models.Models;
using Student_Repository.DbConnection_PostgreSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Repository
{
    public class StudentDataRepository : IStudentDataRepository
    {
        private readonly StudentDatabaseContext _studentDatabaseContext;
        public StudentDataRepository(StudentDatabaseContext studentDatabaseContext)
        {
            _studentDatabaseContext = studentDatabaseContext;
        }
        public async Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            ServiceResponse<Student> serviceResponse = new ServiceResponse<Student>();
            try
            {
                await _studentDatabaseContext.Students.AddAsync(student);
                await _studentDatabaseContext.SaveChangesAsync();
                serviceResponse.Data = student;
                serviceResponse.Message = $"{student.StudentName} record added successfully.";
                return serviceResponse;
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }

        public ServiceResponse<double> getClassMarksAverageDetails(int classId)
        {
            throw new NotImplementedException();
        }
    }
}
