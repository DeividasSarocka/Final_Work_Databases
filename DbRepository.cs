using Final_Work_Databases;
using Final_Work_Databases.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system
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
        public List <Department> GetAllDepartmentsOrdered()
        {
            return _dbContext.Departments.OrderBy(d => d.Name).ToList();     // Koreguoti
        }
        public List<Lecture> GetAllLecturesOrdered()
        {
            return _dbContext.Lectures.OrderBy(d => d.Name).ToList();     // Koreguoti
        }
        public List<Student> GetAllStudentsOrdered()
        {
            return _dbContext.Students.OrderBy(d => d.FirstName).ToList();     // Koreguoti
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public Department GetDepartmentById(int id)
        {
            return _dbContext.Departments.FirstOrDefault(d => d.Id == id);
        }
        public Lecture GetLectureById(int id)
        {
            return _dbContext.Lectures.FirstOrDefault(d => d.Id == id);
        }
        public Student GetStudentById(int id)
        {
            return _dbContext.Students.FirstOrDefault(d => d.Id == id);
        }

        public Student GetStudent(int id)
        {
            return _dbContext.Students.Include(s => s.Departments).FirstOrDefault(s => s.Id == id); 
        }
        public Department GetDepartment(string name)
        {
            return _dbContext.Departments.FirstOrDefault(d => d.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
