using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebDb1.Models
{
    public class JobDetails
    {
        public int Id { get; set; }
        public string Employeenumber { get; set; }
        public string Payment { get; set; }
        public string History { get; set; }
        public string JobLevel { get; set; }
        public string JobRole { get; set; }
        public string JobSatisfaction { get; set; }
        public string OverTime { get; set; }
        public string AccessLevel { get; set; }
    }
}
