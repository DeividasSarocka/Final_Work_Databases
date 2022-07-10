using Final_Work_Databases_Students_info_system;

var businessLogic = new BusinessLogic();
CreateDepartment();
PrintAllDepartmentsToConsole();

void CreateDepartment()
{
    Console.WriteLine("Iveskite Departamento pavadinima:");
    var departmentName = Console.ReadLine();

    businessLogic.CreateDepartment(departmentName);
}
void PrintAllDepartmentsToConsole()                                //trinti nenaudojamas
{
    var departments = businessLogic.GetAllDepartments();
    foreach (var department in departments)
    {
        Console.WriteLine($"Departamento pavadinimas: {department.Name}");
    }
}
void GetDepartmentById()
{
    Console.WriteLine("Iveskite Departamento ID kuri norite pamatyti");
    var id = int.Parse(Console.ReadLine());
    var department = businessLogic.GetDepartmentById(id);
    Console.WriteLine(department.Name);
}
