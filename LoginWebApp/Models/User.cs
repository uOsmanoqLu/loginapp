using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWebApp.Models
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public int City { get; set; }
        public int Region { get; set; }
        public string Phone { get; set; }
    }
}
