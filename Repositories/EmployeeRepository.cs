using System;
using System.Collections.Generic;
using System.Linq;
using WebDb1.Models;
using WebDb1.Data;
using WebDb1.Controllers;
using System.Data;

namespace WebDb1.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private ApplicationDbContext context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {

            return context.Employee.ToList();
        }

        public Employee GetEmployeeByID(int id)
        {
            return context.Employee.Find(id);
        }

        public void InsertEmployee(Employee Employee)
        {
            context.Employee.Add(Employee);
        }

        public void DeleteEmployee(int EmployeeID)
        {
            Employee Employee = context.Employee.Find(EmployeeID);
            context.Employee.Remove(Employee);
        }

        public void UpdateEmployee(Employee Employee)
        {
            context.Entry(Employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
