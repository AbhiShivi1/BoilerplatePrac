using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MYDEMOPROJ.Authorization.Roles;
using MYDEMOPROJ.Authorization.Users;
using MYDEMOPROJ.MultiTenancy;
using MYDEMOPROJ.Model;

namespace MYDEMOPROJ.EntityFrameworkCore
{
    public class MYDEMOPROJDbContext : AbpZeroDbContext<Tenant, Role, User, MYDEMOPROJDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Registration> registrations { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public MYDEMOPROJDbContext(DbContextOptions<MYDEMOPROJDbContext> options)
            : base(options)
        {
        }

    }
}
