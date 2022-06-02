using Abp.Application.Services;
using MYDEMOPROJ.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYDEMOPROJ.Services
{
    public interface ICreateRegistrationAppServices :IApplicationService
    {
        //void createRegister(CreateRegister createRegister);
        void updateRegister(UpdateRegister updateRegister,int id);
    }
   
   
}
