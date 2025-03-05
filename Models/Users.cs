using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleID { get; set; }
        //public Role Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        //public ICollection<UserRole> UserRoles { get; set; }
        public bool EmailConfirmed { get; set; } = false;
        public DateTime? LastLogin { get; set; }
    }
}
