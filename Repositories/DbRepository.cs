using Final_Work_Databases;
using Final_Work_Databases.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system.Repositories
{
    public class DbRepository
    {
        private readonly StudentsDbContext _dbContext;

        public DbRepository()
        {
            _dbContext = new StudentsDbContext();
        }


        public void AddDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
        }
        public void AddLecture(Lecture lecture)
        {
            _dbContext.Lectures.Add(lecture);
        }
        public void AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
        }
        public List<Department> GetAllDepartmentsOrdered() //GetDepartments return _dbContext.Departments.Include(x => x.Lectures).Include(x => x.Students).ToList();
        {
            return _dbContext.Departments.OrderBy(d => d.Name).ToList();     // Koreguoti
        }
        public List<Lecture> GetAllLectures()
        {
            return _dbContext.Lectures.Include(x => x.Departments).Include(x => x.Students).ToList();
        }
        public List<Department> ShowAllDepartments()
        {
            return _dbContext.Departments.ToList();
        }
        public List<Lecture> ShowAllLectures()
        {
            return _dbContext.Lectures.ToList();
        }
        public List<Student> ShowAllStudents()
        {
            return _dbContext.Students.ToList();
        }
        public List<Student> GetAllStudentsOrdered() //GetStudents return _dbContext.Students.Include(x => x.Lectures).ToList();
        {
            return _dbContext.Students.OrderBy(d => d.FirstName).ToList();
        }

        public Department GetDepartmentById(int id)  
        {
            //return _dbContext.Departments.FirstOrDefault(d => d.Id == id);
            return _dbContext.Departments.Include(x => x.Lectures).Include(x => x.Students).FirstOrDefault(d => d.Id == id);
        }
        public Lecture GetLectureById(int id)  
        {
            //return _dbContext.Lectures.FirstOrDefault(d => d.Id == id);
            return _dbContext.Lectures.Include(x => x.Departments).Include(x => x.Students).FirstOrDefault(d => d.Id == id);
        }
        public Student GetStudentById(int id) //return _dbContext.Students.Include(x => x.Lectures).FirstOrDefault(x => x.Id == id);
        {
            //return _dbContext.Students.FirstOrDefault(d => d.Id == id);
            //return _dbContext.Students.Include(x => x.Lectures).FirstOrDefault(d => d.Id == id);
            return _dbContext.Students.Include(x => x.Departments).Include(x => x.Lectures).FirstOrDefault(d => d.Id == id);
        }

        public Student GetStudent(int id)
        {
            return _dbContext.Students.Include(s => s.Departments).FirstOrDefault(s => s.Id == id);
        }
        public Department GetDepartment(string department)
        {
            return _dbContext.Departments.FirstOrDefault(d => d.Name.ToUpper() == department.ToUpper());
        }
        public void UpdateStudent(Student student)
        {
            _dbContext.Attach(student); //prijungimas prie dbContext change trackerio
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
