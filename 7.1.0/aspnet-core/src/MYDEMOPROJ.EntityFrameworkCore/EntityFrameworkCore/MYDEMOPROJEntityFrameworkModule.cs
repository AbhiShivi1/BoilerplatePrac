using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MYDEMOPROJ.EntityFrameworkCore.Seed;

namespace MYDEMOPROJ.EntityFrameworkCore
{
    [DependsOn(
        typeof(MYDEMOPROJCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class MYDEMOPROJEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MYDEMOPROJDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MYDEMOPROJDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MYDEMOPROJDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MYDEMOPROJEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
