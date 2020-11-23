using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string Department1 { get; set; }
        public string Education { get; set; }
        public string EducationField { get; set; }
        public string EnvSatisfaction { get; set; }

        public string AccessLevel { get; set; }
    }
}
