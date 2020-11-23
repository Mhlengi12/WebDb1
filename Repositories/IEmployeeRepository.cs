using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDb1.Models;
using System.Data;

namespace WebDb1.Repositories
{
    public interface IEmployeeRepository : IDisposable
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByID(int EmployeeId);
        void InsertEmployee(Employee Employee);
        void DeleteEmployee(int EmployeeID);
        void UpdateEmployee(Employee Employee);
        void Save();
    }
}
