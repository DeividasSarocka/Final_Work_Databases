﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases.Models
{
    public class Department
    {
        public int Id { get; set; } //stulpeliai
        public string Name { get; set; }
       // public string Students { get; set; }
       // public string Lectures { get; set; }    
        public List<Student> Students { get; set; }  // rysiai tarp lenteliu
        public List <Lecture> Lectures { get; set; }

    }
}