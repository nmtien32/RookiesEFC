using RookiesEFC.Data;
using RookiesEFC.Models;
using RookiesEFC.Repositories;

namespace RookiesEFC.Services
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentContext context) : base(context)
        {
        }
    }
};