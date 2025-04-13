
using coreApiC5.Server.DTO;
using coreApiC5.Server.IDataService;
using coreApiC5.Server.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace coreApiC5.Server.DataService
{
    public class DataServicee : IDataServicee
    {
        private readonly MyDbContext _db;
        public DataServicee(MyDbContext db)
        {
            _db = db;
        }

        public List<Teacher> getTeachers()
        {
            var teachers = _db.Teachers.ToList();
            return teachers;
        }

        public Teacher getTeacherById(int id)
        {
            var teacher = _db.Teachers.FirstOrDefault(x => x.Id == id);
            return teacher;
        }


        public List<Teacher> getTeacherByName(string name)
        {
            var teacher = _db.Teachers.Where(x => x.Name == name).ToList();
            return teacher;
        }





        public List<Student> getAllStudent()
        {
            var students = _db.Students.ToList();
            return students;
        }


        public Student getStudentById(int id)
        {
            var student = _db.Students.FirstOrDefault(x => x.Id == id);

            return student;
        }


        public List<Student> getStudentByName(string name)
        {
            var students = _db.Students.Where(x => x.Name == name).ToList();
            return students;
        }

        public Student getFirstStudent()
        {
            var student = _db.Students.First();

            return student;

        }




        public bool deleteTeacher(int id)
        {

            var teacher = _db.Teachers.FirstOrDefault(x => x.Id == id);
            if (teacher != null)
            {
                _db.Teachers.Remove(teacher);
                _db.SaveChanges();
                return true;


            }

            return false;
        }

        public bool deleteStudent(int id)
        {
            var student = _db.Students.Find(id);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
                return true;
            }
            return false;

        }


        //bussiness logic layer + model (database)
        public bool addStudent(studentRequestDTO student)
        {
            var obj = new Student
            {
                Name = student.Name,
                Email = student.Email,
            };
            _db.Students.Add(obj);
            _db.SaveChanges();
            return true;


        }

        public bool editStudent(int id, studentRequestDTO student)
        {

            var existStudent = _db.Students.Find(id);

            if (existStudent == null)
                return false;
            else
            {
                existStudent.Name = student.Name;
                existStudent.Email = student.Email;
                _db.SaveChanges();
                return true;
                  

            }

           

        }


    }
}
