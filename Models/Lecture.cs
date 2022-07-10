using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        //public string Departments { get; set; }
        public List<Department> Departments { get; set; }  //many su many rysys
        public List<Student> Students { get; set; }
 

    }
}
