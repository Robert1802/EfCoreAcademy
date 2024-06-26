using EfCoreAcademy.Model;

namespace EfCoreAcademy.Repository;

public interface IStudentRepository
{
    Task<int> CreateStudentAsync(Student student);
    Task UpdateStudentAsync(Student student);
    Task<Student?> GetStudentByIdAsync(int studentId);
    Task<List<Student>> GetAllStudentsAsync();
    Task DeleteStudentAsync(int studentId);
}
