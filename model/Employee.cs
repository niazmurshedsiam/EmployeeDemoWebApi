using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeType { get; set; }
        public int DesignationId { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;
        public string Religion { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Salary { get; set; }
        public byte IsActive { get; set; }

    }
}
