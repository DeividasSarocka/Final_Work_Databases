using Final_Work_Databases_Students_info_system;
using Final_Work_Databases_Students_info_system.BusinessLogic;
using Final_Work_Databases_Students_info_system.NewFolder;

var businessLogic = new BusinessLogic();
var userInterface = new UserInterface();
userInterface.ControlPanel();






void PrintAllDepartmentsToConsole()                                //trinti nenaudojamas
{
    var departments = businessLogic.GetAllDepartments();
    foreach (var department in departments)
    {
        Console.WriteLine($"Departamento pavadinimas: {department.Name}");
    }
}
//void PrintAllLecturesToConsole()
//{
//    var lectures = businessLogic.GetAllLectures();
//    foreach (var lecture in lectures)
//    {
//        Console.WriteLine($"Paskaitos pavadinimas: {lecture.Name}");
//    }
//}
//void PrintAllStudentsToConsole()
//{
//    var students = businessLogic.GetAllStudents();
//    foreach (var student in students)
//    {
//        Console.WriteLine($"Studento vardas ir pavardė: {student.FirstName} {student.LastName}");
//    }
//}
void GetDepartmentById()
{
    Console.WriteLine("Iveskite Departamento ID kuri norite pamatyti");
    var id = int.Parse(Console.ReadLine());
    var department = businessLogic.GetDepartmentById(id);
    Console.WriteLine(department.Name);
}
void GetLectureById()
{
    Console.WriteLine("Iveskite Paskaitos ID kurios norite pamatyti");
    var id = int.Parse(Console.ReadLine());
    var lecture = businessLogic.GetLectureById(id);
    Console.WriteLine(lecture.Name);
}
void GetStudentById()
{
    Console.WriteLine("Iveskite Studento ID kuri norite pamatyti");
    var id = int.Parse(Console.ReadLine());
    var student = businessLogic.GetStudentById(id);
    Console.WriteLine(student.FirstName, student.LastName);
}
