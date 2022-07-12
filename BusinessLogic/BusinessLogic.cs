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
        private readonly DbRepository _repository;         //susikuriam fielda

        public BusinessLogic()
        {
            _repository = new DbRepository();
        }

        //public void CreateDepartmentWithStudentsAndLectures(string departmentName, int lectureId, int studentId)  //pasidaryti ilgesni metoda, dasideti studentus ir paskaitas susieti skirtingas lenteles 1 UZDUOTIS darem per paskaitas (ARBA NE)
        //{
        //    var department = new Department(departmentName);
        //    //public void AddDepartment(Department department)
        //    //{
        //    //    _dbContext.Departments.Add(department);
        //    //}
        //    _repository.AddDepartment(department);
        //    _repository.SaveChanges();
        //}
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
        public void CreateStudent(string firstName, string lastName, int departmentId)  //departmentId nereikalingas??Priskiriam veliau?
        {
            var student = new Student(firstName, lastName, departmentId);

            _repository.AddStudent(student);
            _repository.SaveChanges();
        }
        //public void ShowDepartments()                -------------------------- Grazinti Departamentus is Repositorijos UserioInterface išprintinti per fOREACHA SUTVARKYTI
        //{
        //    Console.WriteLine("Department's ID, Name:");
        //    foreach (var department in _repository.RetrieveDepartments())
        //    {
        //        Console.WriteLine($"{department.Id}, {department.Name}");
        //    }

        //public void ShowDepartmentsByLecture(int lectureId)
        //{
        //    Lecture lecture = _repository.RetrieveLectureById(lectureId);
        //    Console.WriteLine("Department's ID, Name:");
        //    foreach (var department in _repository.RetrieveDepartments())
        //    {
        //        if (department.Lectures.Contains(lecture))
        //        {
        //            Console.WriteLine($"{department.Id}, {department.Name}");
        //        }
        //    }
        //}
        //public void ShowDepartmentsByStudent(int studentId)
        //{
        //    Student student = _repository.RetrieveStudentById(studentId);
        //    Console.WriteLine("Department's ID, Name:");
        //    foreach (var department in _repository.RetrieveDepartments())
        //    {
        //        if (department.Students.Contains(student))
        //        {
        //            Console.WriteLine($"{department.Id}, {department.Name}");
        //        }
        //    }
        //}
        //public void ShowLecturesByStudent(int studentId)
        //{
        //    Student student = _repository.RetrieveStudentById(studentId);
        //    Console.WriteLine("Lecture's ID, Name, No. of credits:");
        //    foreach (var lecture in _repository.RetrieveLectures())
        //    {
        //        if (lecture.Students.Contains(student))
        //        {
        //            Console.WriteLine($"{lecture.Id}, {lecture.Name}, {lecture.Credits}");
        //        }
        //    }
        //}
        //!!!!!!taip pat su  ShowStudents(); ShowStudentsByDepartment(int departmentId); ShowStudentsByLecture(int lectureId)

        public List<Department> GetAllDepartments()       // Koreguoti
        {
            return _repository.GetAllDepartmentsOrdered();
        }
        //public List<Lecture> GetAllLectures()       // Koreguoti
        //{
        //    return _repository.GetAllLecturesOrdered();
        //}
        public List<Student> GetAllStudents()       // Koreguoti
        {
            return _repository.GetAllStudentsOrdered();
        }
        public Department GetDepartmentById(int id)
        {
            return _repository.GetDepartmentById(id);
        }

        public Lecture GetLectureById(int id)
        {
            return _repository.GetLectureById(id);
        }

        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
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
        //public void AssignStudentToLecture(int studentId, int lectureId)
        //{
        //    Student student = _repository.RetrieveStudentById(studentId);
        //    Lecture lecture = _repository.RetrieveLectureById(lectureId);

        //    student.Lectures.Add(lecture);
        //    _repository.SaveChanges();
        //}
        public void AssignAllDepartmentLecturesToStudent(Student student, Department department)
        {
            student.Lectures.Clear();
            foreach (var lecture in department.Lectures)
            {
                student.Lectures.Add(lecture);
            }
            _repository.SaveChanges();
        }

        //public void AssignDepartmentToStudent(int studentId, string department) //gal int departmentId?
        //{
        //    var student = _repository.GetStudent(studentId);
        //    //if (student.Departments.Any(d => d.Name.Equals(department, StringComparison.InvariantCultureIgnoreCase)))
        //    //{
        //    //    return;
        //    //}
        //    var departmentFromDb = _repository.GetDepartment(department);

        //    //student.Departments.Add(departmentFromDb ?? new Department(department)); //if else

        //    _repository.UpdateStudent(student);
        //    _repository.SaveChanges();
        //}


        //AssignLectureToDepartment

    }
}
