using Abp.Application.Services.Dto;

namespace MYDEMOPROJ.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

