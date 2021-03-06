using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBWorks.Entities;

namespace DBWorks.Services
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
    }
}
