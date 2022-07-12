using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Work_Databases.Models;
using Final_Work_Databases_Students_info_system.BusinessLogic;

namespace Final_Work_Databases_Students_info_system.NewFolder
{
    public class UserInterface
    {
        private readonly BusinessLogic.BusinessLogic _businessLogic;
        private readonly Repositories.DbRepository _repository;
        public UserInterface()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
            _repository = new Repositories.DbRepository();
        }
        public void ControlPanel()
        {
            Console.WriteLine("Sveiki atvyke i DB atsiskaityma");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės iš sukurtų funkcionalumų MENIU sąrašo:\nMENIU" +
                    "\n[1]-Sukurti departamentą ir į jį pridėti studentus, paskaitas" +
                    "\n[2]-Prideti studentus/paskaitas i jau egzistuojanti departamenta" +
                    "\n[3]-Sukurti paskaita ir ja priskirti prie departamento" +
                    "\n[4]-Sukurti studenta, ji prideti prie egzistuojančio departamento ir priskirti jam egzistuojancias paskaitas" +
                    "\n[5]-Perkelti studentą į kitą departamentą" +
                    "\n[6]-Atvaizduoti visus departamento studentus" +
                    "\n[7]-Atvaizduoti visas departamento paskaitas" +
                    "\n[8]-Atvaizduoti visas paskaitas pagal studentą" +
                    "\n[0]-Išeiti"); 
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        repeat = false;
                        break;
                    case "1":
                        Console.Clear();
                        Task1ControlPanel();
                        break;
                    case "2":
                        Console.Clear();
                        Task2ControlPanel();
                        break;
                    case "3":
                        Console.Clear();
                        Task3ControlPanel();
                        break;
                    case "4":
                        Console.Clear();
                        Task4ControlPanel();
                        break;
                    case "5":
                        Console.Clear();
                        AssignDepartmentToStudent();
                        break;
                    case "6":
                        Console.Clear();
                        ShowStudentsByDepartment();
                        break;
                    case "7":
                        Console.Clear();
                        ShowLecturesByDepartment();
                        break;
                    case "8":
                        Console.Clear();
                        ShowLecturesByStudent();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Task1ControlPanel()
        {
            Console.WriteLine("1 Uzduotis: Sukurti departamentą ir į jį pridėti studentus, paskaitas");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės veiksmus:\n[1]-Sukurti departamentą\n[2]-Priskirti departamentui paskaitas\n[3]-Priskirti departamentui studentus\n[0]-Iseiti"); 
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        repeat = false;
                        break;
                    case "1":
                        Console.Clear();
                        CreateDepartment();
                        break;
                    case "2":
                        Console.Clear();
                        AssignDepartmentToLecture();
                        break;
                    case "3":
                        Console.Clear();
                        AssignDepartmentToStudent();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        break;
                }
            }

        }
        public void Task2ControlPanel()
        {
            Console.WriteLine("2 Uzduotis: Prideti studentus/paskaitas i jau egzistuojanti departamenta");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės veiksmus:\n[1]-Pridėti paskaitas į departamentą\n[2]-Pridėti studentus į departamentą\n[0]-Iseiti");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        repeat = false;
                        break;
                    case "1":
                        Console.Clear();
                        AssignDepartmentToLecture();
                        break;
                    case "2":
                        Console.Clear();
                        AssignDepartmentToStudent();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Task3ControlPanel()
        {
            Console.WriteLine("3 Uzduotis: Sukurti paskaita ir ja priskirti prie departamento");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės veiksmus:\n[1]-Sukurti paskaitą\n[2]-Priskirti paskaitą prie departamento\n [0]-Iseiti");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        repeat = false;
                        break;
                    case "1":
                        Console.Clear();
                        CreateLecture();
                        break;
                    case "2":
                        Console.Clear();
                        AssignDepartmentToLecture();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Task4ControlPanel()
        {
            Console.WriteLine("4 Uzduotis: Sukurti studenta, ji prideti prie egzistuojančio departamento ir priskirti jam egzistuojancias paskaitas");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės veiksmus:\n[1]-Sukurti studentą\n[2]-Pridėti studentą prie departamento\n[3]- Priskirti studentui paskaitas\n [0]-Iseiti");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Console.Clear();
                        repeat = false;
                        break;
                    case "1":
                        Console.Clear();
                        CreateStudent();
                        break;
                    case "2":
                        Console.Clear();
                        AssignDepartmentToStudent();
                        break;
                    case "3":
                        Console.Clear();
                        AssignStudentToLecture();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void CreateDepartment()
        {
            Console.WriteLine("Iveskite Departamento pavadinima:");
            var departmentName = Console.ReadLine();
            _businessLogic.CreateDepartment(departmentName);
            Console.WriteLine("Departamentas sukurtas");
            Console.ReadLine();
        }
        public void CreateLecture()
        {
            Console.WriteLine("Iveskite Paskaitos pavadinima:");
            var lectureName = Console.ReadLine();
            _businessLogic.CreateLecture(lectureName);
            Console.WriteLine("Paskaita sukurta");
            Console.ReadLine();
        }
        public void CreateStudent()
        {
            Console.WriteLine("Iveskite Studento vardą:");
            var studentFirstName = Console.ReadLine();
            Console.WriteLine("Iveskite Studento pavardę:");
            var studentLastName = Console.ReadLine();
            _businessLogic.CreateStudent(studentFirstName, studentLastName);
        }
        public void AssignDepartmentToLecture()
        {
            Console.WriteLine("Iveskite Departamento ID:");
            ShowDepartments();
            var departmentId = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Iveskite paskaitos, kuria norite priskirti ID");
            ShowLectures();
            var lectureId = int.Parse(Console.ReadLine());
            _businessLogic.AssignDepartmentToLecture(departmentId, lectureId);
        }
        public void AssignDepartmentToStudent()
        {
            Console.WriteLine("Iveskite Departamento ID:");
            ShowDepartments();
            var departmentId = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Iveskite studento, kuri norite priskirti ID");
            ShowStudents();
            var studentId = int.Parse(Console.ReadLine());
            _businessLogic.AssignDepartmentToStudent(departmentId, studentId);
        }
        public void AssignStudentToLecture()
        {
            Console.WriteLine("Iveskite Studento ID:");
            ShowStudents();
            var studentId = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Iveskite Paskaitos, kuria norite priskirti ID");
            ShowLectures();
            var lectureId = int.Parse(Console.ReadLine());
            _businessLogic.AssignStudentToLecture(studentId, lectureId);
        }
        public void ShowDepartments()
        {
            Console.WriteLine("Departamento ID, Pavadinimas:");
            foreach (var department in _repository.ShowAllDepartments())
            {
                Console.WriteLine($"{department.Id}, {department.Name}");
            }
        }
        public void ShowLectures()               
        {
            Console.WriteLine("Paskaitu ID, Pavadinimas:");
            foreach (var lecture in _repository.ShowAllLectures())
            {
                Console.WriteLine($"{lecture.Id}, {lecture.Name}");
            }
        }
        public void ShowStudents()
        {
            Console.WriteLine("Studento ID, Vardas, Pavarde:");
            foreach (var student in _repository.ShowAllStudents())
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}");
            }
        }
        public void ShowStudentsByDepartment()
        {
            Console.WriteLine("Įveskite Departamento ID:");
            ShowDepartments();
            var departmentId = int.Parse(Console.ReadLine());
            Department department = _repository.GetDepartmentById(departmentId);
            var students = department.Students;
            Console.WriteLine("Studentų ID, Vardas Pavardė:");
            foreach (var student in students)
            { 
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}");
            }
            Console.ReadLine();
        }
        public void ShowLecturesByDepartment()
        {
            Console.WriteLine("Įveskite Departamento ID:");
            ShowDepartments();
            var departmentId = int.Parse(Console.ReadLine());
            Department department = _repository.GetDepartmentById(departmentId);
            var lectures = department.Lectures;
            Console.WriteLine("Paskaitų ID, Pavadinimas:");
            foreach (var lecture in lectures)
            {
                    Console.WriteLine($"{lecture.Id}, {lecture.Name}");
            }
            Console.ReadLine();
        }
        public void ShowLecturesByStudent()
        {
            Console.WriteLine("Įveskite Studento ID:");
            ShowStudents();
            var studentId = int.Parse(Console.ReadLine());
            Student student = _repository.GetStudentById(studentId);
            var lectures = student.Lectures;
            Console.WriteLine("Paskaitos ID, Pavadinimas:");
            foreach (var lecture in lectures)
            {
                    Console.WriteLine($"{lecture.Id}, {lecture.Name}");
            }
            Console.ReadLine();
        }
    }
}

