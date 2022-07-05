using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TeoGarden.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        //public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsBlocked { get; set; }
    }
}
