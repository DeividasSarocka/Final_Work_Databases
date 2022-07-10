using Final_Work_Databases;
using Final_Work_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases_Students_info_system
{
    public class DbRepository
    {
        private readonly StudentsDbContext _dbContext;

        public DbRepository()
        {
            _dbContext = new StudentsDbContext();
        }


        public void AddDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
        }
        public List <Department> GetAllDepartmentsOrdered()
        {
            return _dbContext.Departments.OrderBy(d => d.Name).ToList();     // trinti, nenaudojamas
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
