using Abp.Application.Services;
using MYDEMOPROJ.MultiTenancy.Dto;

namespace MYDEMOPROJ.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

