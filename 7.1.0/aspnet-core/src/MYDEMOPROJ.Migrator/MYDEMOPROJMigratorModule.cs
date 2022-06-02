using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MYDEMOPROJ.Configuration;
using MYDEMOPROJ.EntityFrameworkCore;
using MYDEMOPROJ.Migrator.DependencyInjection;

namespace MYDEMOPROJ.Migrator
{
    [DependsOn(typeof(MYDEMOPROJEntityFrameworkModule))]
    public class MYDEMOPROJMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MYDEMOPROJMigratorModule(MYDEMOPROJEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MYDEMOPROJMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MYDEMOPROJConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MYDEMOPROJMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
