﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Work_Databases;
using Final_Work_Databases.Models;

namespace Final_Work_Databases.Models
{
    public class Department
    {
        public int Id { get; set; } //stulpeliai
        public string Name { get; set; }
        public List<Student> Students { get; set; }  // rysiai tarp lenteliu
        public List <Lecture> Lectures { get; set; }
        private Department()
        {
             
        }
        public Department( string name)
        {
            Name = name;
            Students = new List<Student>();
            Lectures = new List<Lecture>();
        }

     
        internal void Add(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
