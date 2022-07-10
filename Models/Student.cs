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
 
        public List<Lecture> Lectures { get; set; }  //navigation property
        public Department Department { get; set; }  // Department? nullable jei ne visi turi 

        private Student()
        {

        }

        public Student(string firstName, string lastName)        //kuriam konstruktoriu
        {
            FirstName = firstName;
            LastName = lastName;
            Lectures = new List<Lecture>();  //tuscias listas
         
        }

    }
}
