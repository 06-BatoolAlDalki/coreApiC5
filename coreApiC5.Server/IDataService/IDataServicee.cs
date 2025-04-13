using coreApiC5.Server.DTO;
using coreApiC5.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreApiC5.Server.IDataService
{
    public interface IDataServicee
    {

        public List<Teacher> getTeachers();
        public Teacher getTeacherById(int id);
        public List<Teacher> getTeacherByName(string name);



        public List<Student> getAllStudent();
        public Student getStudentById(int id);
        public List<Student> getStudentByName(string name);
        public Student getFirstStudent();
        public bool deleteTeacher(int id);
        public bool deleteStudent(int id);

        public bool addStudent(studentRequestDTO student);


        public bool editStudent(int id, studentRequestDTO student);
    }
}
