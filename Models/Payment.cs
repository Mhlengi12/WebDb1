using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Employeenum { get; set; }
        public int? PercentSalaryRate { get; set; }
        public int? DailyRate { get; set; }
        public int? HourlyRate { get; set; }
        public int? MonthlyIncome { get; set; }
        public int? MonthlyRate { get; set; }
        public string AccessLevel { get; set; }
    }
}
