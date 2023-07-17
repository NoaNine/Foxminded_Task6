using System.Data.Entity;
using University.Models;

namespace University.DAL
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private UniversityContext _context;
        private bool _disposed = false;

        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentByID(int id)
        {
            return _context.Students.Find(id);
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public void DeleteStudent(int studentID)
        {
            Student student = _context.Students.Find(studentID);
            _context.Students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}