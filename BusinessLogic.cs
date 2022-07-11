using Final_Work_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system
{
    public class BusinessLogic
    {
        private readonly DbRepository _repository;         //susikuriam fielda

        public BusinessLogic()
        {
             _repository = new DbRepository();
        }

        public void CreateDepartment(string name)
        {
            var department = new Department(name);

            _repository.AddDepartment(department);
            _repository.SaveChanges();
        }
        public List <Department> GetAllDepartments()       // Koreguoti
        {
            return _repository.GetAllDepartmentsOrdered();
        }
        public List<Lecture> GetAllLectures()       // Koreguoti
        {
            return _repository.GetAllLecturesOrdered();
        }
        public List<Student> GetAllStudents()       // Koreguoti
        {
            return _repository.GetAllStudentsOrdered();
        }
        public Department GetDepartmentById(int id)
        {
            return _repository.GetDepartmentById(id);
        }
        public void CreateLecture(string name)
        {
            var lecture = new Lecture(name);

            _repository.AddLecture(lecture);
            _repository.SaveChanges();
        }
        public Lecture GetLectureById(int id)
        {
            return _repository.GetLectureById(id);
        }
        public void CreateStudent(string firstName, string lastName, int departmentId)
        {
            var student = new Student(firstName, lastName, departmentId);

            _repository.AddStudent(student);
            _repository.SaveChanges();
        }
        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }
        public void AssignDepartmentToStudent(int studentId,string department) //gal int departmentId?
        {
            var student = _repository.GetStudent(studentId);
            //if (student.Departments.Any(d => d.Name.Equals(department, StringComparison.InvariantCultureIgnoreCase)))
            //{
            //    return;
            //}
            var departmentFromDb = _repository.GetDepartment(department);
            student.Departments.Add(departmentFromDb ?? new Department(department)); //if else
            
            _repository.UpdateStudent(student);
            _repository.SaveChanges();
        }


            //AssignLectureToDepartment

    }
}
