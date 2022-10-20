using RookiesEFC.Models;
using RookiesEFC.DTOs;

namespace RookiesEFC.Services;

public interface IStudentService
{
    AddStudentResponse Create(AddStudentRequest createModel);
    IEnumerable<Student> GetAll();
    bool Delete(int id);
    UpdateStudentResponse Update(int id, UpdateStudentRequest updateRequest);

}