//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Final_Work_Databases_Students_info_system.NewFolder
//{
//    public class UserInterface
//    {
//        private readonly BusinessLogic _businessLogic;
//        public UserInterface()
//        {
//            _businessLogic = new BusinessLogic();
//        }
//        public void Controls ()
//        {
//            Console.WriteLine("Welcome to Students database system");
//            Console.ReadLine();

//            bool repeat = true;
//            string userInput;

//            while (repeat)
//            {
//                Console.Clear();
//                Console.WriteLine("MENIU\n[1]-Add\n[2]-Show All\n[3]-Show By\n [4]-Assign");  //PERSIKOREGUOTI 
//                userInput = Console.ReadLine();
//                switch (userInput)
//                {
//                    case "1":
//                        Console.Clear();
//                        //CreateEntity();
//                        break;
//                    case "2":
//                        Console.Clear();
//                        //ShowAllEntities();
//                        break;
//                    case "3":
//                        Console.Clear();
//                        //ShowBy();
//                        break;
//                    case "4":
//                        //Assign();
//                        break;
//                    case "5":
//                        Console.Clear();
//                        repeat = false;
//                        break;
//                    default:
//                        Console.Clear();
//                        Console.WriteLine("Wrong input");
//                        Console.ReadLine();
//                        break;
//                }
//                public void CreateEntity()
//                {
//                    bool repeat = true;
//                    string userInput;

//                    while (repeat)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Select what to add:\n[1]-Department\n[2]-Lecture\n[3]-Student\n[4]-Exit");
//                        userInput= Console.ReadLine();

//                        switch (userInput)
//                        {
//                            case "1":
//                                Console.Clear();
//                                Console.WriteLine("Enter department's name:");
//                                string DepartmentName = Console.ReadLine();
//                                _businessLogic.CreateDepartment(DepartmentName);
//                                break;
//                            case "2":
//                                Console.Clear();
//                                Console.WriteLine("Enter lecture's name:");
//                                string lectureName = Console.ReadLine();
//                                _businessLogic.CreateLecture(lectureName);
//                                break;
//                            case"3":
//                                Console.Clear();
//                                Console.WriteLine("Enter student's name:");
//                                string studentName = Console.ReadLine();
//                                _businessLogic.CreateStudent(studentName);
//                                break;
//                            case"4":
//                                Console.Clear();
//                                repeat = false;
//                                break;
//                            default:
//                                Console.Clear();
//                                Console.WriteLine("Wrong input");
//                                Console.ReadLine();
//                                break;
//                        }
//                    }
//                }
//                public void ShowAllEntities()
//                {
//                    bool repeat = true;
//                    string userInput;
//                    while (repeat)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Select what do you want to see: \n [1] - All departments \n - All lectures");
//                        userInput = Console.ReadLine();

//                        switch (userInput)
//                        {
//                            case "1":
//                                Console.Clear();
//                                _businessLogic.ShowDepartments();
//                                Console.ReadLine();
//                                break;
//                            case "2":
//                                Console.Clear();
//                                _businessLogic.ShowLectures();
//                                Console.ReadLine();
//                                break;
//                            case "3":
//                                Console.Clear();
//                                _businessLogic.ShowStudents();
//                                Console.ReadLine();
//                                break;
//                            case "4":
//                                Console.Clear();
//                                repeat = false;
//                                break;
//                            default:
//                                Console.Clear();
//                                Console.WriteLine("Wrong input");
//                                Console.ReadLine();
//                                break;
//                        }

//                    }

//                }
//                public void ShowBy()
//                {
//                    bool repeat = true;
//                    string userInput;
//                    while (repeat)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Select what do you want to see: \n[1]- Departments by lecture");
//                        userInput= Console.ReadLine();

//                        int departmentId;
//                        int lectureId;
//                        int studentId;
//                        switch (userInput)
//                        {
//                            case "1":
//                                Console.Clear();
//                                lectureId = GetLectureId();
//                                Console.Clear();
//                                _businessLogic.ShowDepartmentsByLecture(lectureId);
//                                Console.ReadLine();
//                                break;
//                            case"2":
//                                Console.Clear();
//                                Console.WriteLine("Enter student's ID:");
//                                _businessLogic.ShowStudents();
//                                Console.WriteLine();
//                                studentId = Int32.Parse(Console.ReadLine());
//                                Console.Clear();
//                                _businessLogic.ShowDepartmentByStudent(studentId);
//                                Console.Readline();
//                                break;
//                            // 2022-07-05 52,4 min
//                            default:
//                                break;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
