using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MYDEMOPROJ.Authorization;

namespace MYDEMOPROJ
{
    [DependsOn(
        typeof(MYDEMOPROJCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MYDEMOPROJApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MYDEMOPROJAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MYDEMOPROJApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
