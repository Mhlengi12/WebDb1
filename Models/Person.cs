using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int? EmployeeNumber { get; set; }
        public int? Age { get; set; }
        public int? DistanceFromHome { get; set; }
        public string Gender { get; set; }
        public string MartialStatus { get; set; }
        public string Over18 { get; set; }
        public string RelationshipSatisfacion { get; set; }
        public string AccessLevel { get; set; }
    }
}
