using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MYDEMOPROJ.EntityFrameworkCore
{
    public static class MYDEMOPROJDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MYDEMOPROJDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MYDEMOPROJDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
