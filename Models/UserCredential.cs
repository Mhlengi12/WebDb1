using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDb1.Models
{
    public class UserCredential
    {
        public int Id { get; set; }
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }
    }
}
