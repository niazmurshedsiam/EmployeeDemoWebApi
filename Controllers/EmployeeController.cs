using EmployeeDemo.context;
using EmployeeDemo.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        ApplicationDbContext _DbContext;
        public EmployeeController(ApplicationDbContext DbContext) 
        {
            _DbContext = DbContext;
        }
        [HttpGet]
        public List<Employee> AllEmplyee()
        {
            var employes = _DbContext.Employees.ToList();
            return employes;
        }
        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            _DbContext.Employees.Add(employee);
            bool isActive = _DbContext.SaveChanges()>0;

            if (isActive)
            {
                return employee;
            }
            return null;
        }

        [HttpGet("{id}")]
        public Employee GetEmployeesByID(int id)
        {
            return _DbContext.Employees.FirstOrDefault(s=>s.EmployeeId == id);
            
        }

        [HttpGet("{name}")]
        public Employee GetEmployeesByName(string name)
        {
            return _DbContext.Employees.FirstOrDefault(s => s.FirstName == name);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _DbContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if ( employee!= null)
            {
                _DbContext.Employees.Remove(employee);
                _DbContext.SaveChanges();
            }
        }
    }
}
