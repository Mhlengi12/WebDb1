using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeNum { get; set; }
        public string Department { get; set; }
        public string JobRole { get; set; }
        public string BusinessTravel { get; set; }
        public int EmployeeCount { get; set; }
        public string Attrition { get; set; }
        public string WorkLifeBalance { get; set; }
        public int PerformanceRating { get; set; }
        public string AccessLevel { get; set; }
    }
}
