using Final_Work_Databases.Models;
using Final_Work_Databases_Students_info_system.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system.BusinessLogic
{
    public class BusinessLogic
    {
        private readonly DbRepository _repository;         
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
        public void CreateLecture(string name)
        {
            var lecture = new Lecture(name);
            _repository.AddLecture(lecture);
            _repository.SaveChanges();
        }
        public void CreateStudent(string firstName, string lastName)  
        {
            var student = new Student(firstName, lastName);
            _repository.AddStudent(student);
            _repository.SaveChanges();
        }
        public void AssignDepartmentToLecture(int departmentId, int lectureId)
        {
            Department department = _repository.GetDepartmentById(departmentId);
            Lecture lecture = _repository.GetLectureById(lectureId);
            lecture.Departments.Add(department);
            _repository.SaveChanges();
        }
        public void AssignDepartmentToStudent(int departmentId, int studentId)
        {
            Department department = _repository.GetDepartmentById(departmentId);
            Student student = _repository.GetStudentById(studentId);
            student.Departments = department;
            AssignAllDepartmentLecturesToStudent(student, department);
            _repository.SaveChanges();
        }
        public void AssignStudentToLecture(int studentId, int lectureId)
        {
            Student student = _repository.GetStudentById(studentId);
            Lecture lecture = _repository.GetLectureById(lectureId);

            student.Lectures.Add(lecture);
            _repository.SaveChanges();
        }
        public void AssignAllDepartmentLecturesToStudent(Student student, Department department)
        {
            student.Lectures.Clear();
            foreach (var lecture in department.Lectures)
            {
                student.Lectures.Add(lecture);
            }
            _repository.SaveChanges();
        }
    }
}
