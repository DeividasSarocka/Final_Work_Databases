﻿using Final_Work_Databases;
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
        public List<Lecture> GetAllLectures()
        {
            return _dbContext.Lectures.Include(x => x.Departments).Include(x => x.Students).ToList();
        }
        public List<Student> GetStudents()
        {
            return _dbContext.Students.Include(x => x.Lectures).ToList();
        }
        public Department GetDepartmentById(int id)  
        {
            return _dbContext.Departments.Include(x => x.Lectures).Include(x => x.Students).FirstOrDefault(d => d.Id == id);
        }
        public Lecture GetLectureById(int id)  
        {
            return _dbContext.Lectures.Include(x => x.Departments).Include(x => x.Students).FirstOrDefault(d => d.Id == id);
        }
        public Student GetStudentById(int id)
        {
            return _dbContext.Students.Include(x => x.Departments).Include(x => x.Lectures).FirstOrDefault(d => d.Id == id);
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
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
