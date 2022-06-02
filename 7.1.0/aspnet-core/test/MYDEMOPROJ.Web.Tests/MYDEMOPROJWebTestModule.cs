using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MYDEMOPROJ.EntityFrameworkCore;
using MYDEMOPROJ.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MYDEMOPROJ.Web.Tests
{
    [DependsOn(
        typeof(MYDEMOPROJWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MYDEMOPROJWebTestModule : AbpModule
    {
        public MYDEMOPROJWebTestModule(MYDEMOPROJEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MYDEMOPROJWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MYDEMOPROJWebMvcModule).Assembly);
        }
    }
}