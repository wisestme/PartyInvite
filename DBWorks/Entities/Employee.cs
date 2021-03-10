using System.ComponentModel.DataAnnotations.Schema;

namespace DBWorks.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
        public string City { get; set; }
        public int DeptId { get; set; }

    }
}