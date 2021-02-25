using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DBWorks.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
    }
}