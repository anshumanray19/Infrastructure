using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Infrastructure.Models.Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public object UserRoles { get;  set; }
    }

    public class UserRole
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        //public User User { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }
    }

   

    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        //public ICollection<User> Users { get; set; }
    }
    //public class RegisterRequest
    //{
    //    public string UserName { get; set; }
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //    public string Role { get; set; }
    //}

}
