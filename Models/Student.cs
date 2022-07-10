using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Lectures { get; set; }
        //public string Department { get; set; }   // Department? nullable jei ne visi turi 
 
        public List<Lecture> Lectures { get; set; }  //navigation property
        public Department Department { get; set; }
    }
}
