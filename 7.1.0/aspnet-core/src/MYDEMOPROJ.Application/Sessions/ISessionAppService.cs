using System.Threading.Tasks;
using Abp.Application.Services;
using MYDEMOPROJ.Sessions.Dto;

namespace MYDEMOPROJ.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
