using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string DepartmentId { get; set; }
        public string YearsAtCompany { get; set; }
        public string StockOption { get; set; }
        public string NumCompanies { get; set; }
        public string Type { get; set; }
        public string AccessLevel { get; set; }
    }
}
