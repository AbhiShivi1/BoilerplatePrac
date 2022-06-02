using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MYDEMOPROJ.Configuration;

namespace MYDEMOPROJ.Web.Host.Startup
{
    [DependsOn(
       typeof(MYDEMOPROJWebCoreModule))]
    public class MYDEMOPROJWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MYDEMOPROJWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MYDEMOPROJWebHostModule).GetAssembly());
        }
    }
}
