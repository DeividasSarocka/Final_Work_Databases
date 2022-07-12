using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    "\n [0]-Išeiti"); 
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
                        //ShowAllEntities();
                        break;
                    case "3":
                        Console.Clear();
                        //ShowBy();
                        break;
                    case "4":
                        //Assign();
                        break;
                    case "5":
                        Console.Clear();
                        repeat = false;
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
            Console.WriteLine("1 Uzduotis");
            Console.ReadLine();
            bool repeat = true;
            string userInput;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Rinkitės veiksmus:\n[1]-Sukurti departamentą\n[2]-Priskirti departamentui paskaitas\n[3]-Priskirti departamentui studentus\n [0]-Iseiti"); 
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
        public void CreateDepartment()
        {
            Console.WriteLine("Iveskite Departamento pavadinima:");
            var departmentName = Console.ReadLine();
           
            //Console.Clear();
            //Console.WriteLine("Iveskite studento, kuri norite priskirti ID");
            //ShowStudents();
            //var studentId = int.Parse(Console.ReadLine());
            //Console.Clear();
            _businessLogic.CreateDepartment(departmentName);
            Console.WriteLine("Departamentas sukurtas");
            Console.ReadLine();
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
            var lectureId = int.Parse(Console.ReadLine());
            _businessLogic.AssignDepartmentToStudent(departmentId, lectureId);
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

        //public void CreateEntity()
        //{
        //    bool repeat = true;
        //    string userInput;

        //    while (repeat)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Select what to add:\n[1]-Department\n[2]-Lecture\n[3]-Student\n[4]-Exit");
        //        userInput = Console.ReadLine();

        //        switch (userInput)
        //        {
        //            case "1":
        //                Console.Clear();
        //                Console.WriteLine("Enter department's name:");
        //                string DepartmentName = Console.ReadLine();
        //                _businessLogic.CreateDepartment(DepartmentName);
        //                break;
        //            case "2":
        //                Console.Clear();
        //                Console.WriteLine("Enter lecture's name:");
        //                string lectureName = Console.ReadLine();
        //                _businessLogic.CreateLecture(lectureName);
        //                break;
        //            case "3":
        //                Console.Clear();
        //                Console.WriteLine("Enter student's name:");
        //                string studentName = Console.ReadLine();
        //                _businessLogic.CreateStudent(studentName);
        //                break;
        //            case "4":
        //                Console.Clear();
        //                repeat = false;
        //                break;
        //            default:
        //                Console.Clear();
        //                Console.WriteLine("Wrong input");
        //                Console.ReadLine();
        //                break;
        //        }
        //    }
        //}
        //public void ShowAllEntities()
        //{
        //    bool repeat = true;
        //    string userInput;
        //    while (repeat)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Select what do you want to see: \n [1] - All departments \n - All lectures");
        //        userInput = Console.ReadLine();

        //        switch (userInput)
        //        {
        //            case "1":
        //                Console.Clear();
        //                _businessLogic.ShowDepartments();
        //                Console.ReadLine();
        //                break;
        //            case "2":
        //                Console.Clear();
        //                _businessLogic.ShowLectures();
        //                Console.ReadLine();
        //                break;
        //            case "3":
        //                Console.Clear();
        //                _businessLogic.ShowStudents();
        //                Console.ReadLine();
        //                break;
        //            case "4":
        //                Console.Clear();
        //                repeat = false;
        //                break;
        //            default:
        //                Console.Clear();
        //                Console.WriteLine("Wrong input");
        //                Console.ReadLine();
        //                break;
        //        }

        //    }

        //}
        //public void ShowBy()
        //{
        //    bool repeat = true;
        //    string userInput;
        //    while (repeat)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Select what do you want to see: \n[1]- Departments by lecture");
        //        userInput = Console.ReadLine();

        //        int departmentId;
        //        int lectureId;
        //        int studentId;
        //        switch (userInput)
        //        {
        //            case "1":
        //                Console.Clear();
        //                lectureId = GetLectureId();
        //                Console.Clear();
        //                _businessLogic.ShowDepartmentsByLecture(lectureId);
        //                Console.ReadLine();
        //                break;
        //            case "2":
        //                Console.Clear();
        //                Console.WriteLine("Enter student's ID:");
        //                _businessLogic.ShowStudents();
        //                Console.WriteLine();
        //                studentId = Int32.Parse(Console.ReadLine());
        //                Console.Clear();
        //                _businessLogic.ShowDepartmentByStudent(studentId);
        //                Console.Readline();
        //                break;
        //            // 2022-07-05 52,4 min
        //            default:
        //                break;
        //        }
        //    }
        //}

    }
}

