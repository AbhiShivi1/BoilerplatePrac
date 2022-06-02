using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MYDEMOPROJ.MultiTenancy;

namespace MYDEMOPROJ.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
