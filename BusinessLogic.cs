using Final_Work_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system
{
    public class BusinessLogic
    {
        private readonly DbRepository _repository;         //susikuriam fielda

        public BusinessLogic()
        {
             _repository = new DbRepository();
        }

        public void CreateDepartment(string name)
        {
            var department = new Department(name);

            _repository.AddDepartment(department);
            _repository.SaveChanges();
        }
        public List <Department> GetAllDepartments()       // trinti nenaudojamas
        {
            return _repository.GetAllDepartmentsOrdered();
        }
    }
}
