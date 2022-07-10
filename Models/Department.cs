 using System;
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
    }
}
