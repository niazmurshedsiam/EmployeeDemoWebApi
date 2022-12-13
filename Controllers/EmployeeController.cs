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
        public List<Employee> GetAll()
        {
            var employes = _DbContext.Employees.ToList();
            return employes;
        }
    }
}
