using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class History
    {
        public int Id { get; set; }
        public int? EmployeeNumber { get; set; }
        public int? YearsInCurrentRole { get; set; }
        public int? LastPromotionYears { get; set; }
        public int? ManagerYears { get; set; }
        public string Type { get; set; }
        public int? WorkingYears { get; set; }
        public string TrainingTime { get; set; }
        public string AccessLevel { get; set; }
    }
}
