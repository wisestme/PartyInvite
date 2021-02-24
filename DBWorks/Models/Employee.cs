﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBWorks.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ExperienceYears { get; set; }
        public decimal Salary { get; set; }
    }
}