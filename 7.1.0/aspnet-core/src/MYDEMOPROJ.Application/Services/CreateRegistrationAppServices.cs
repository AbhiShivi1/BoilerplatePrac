using Abp.Domain.Repositories;
using Abp.UI;
using MYDEMOPROJ.Model;
using MYDEMOPROJ.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYDEMOPROJ.Services
{
    public class CreateRegistrationAppServices : ICreateRegistrationAppServices
    {
        private readonly IRepository<UpdateRegister> _repository;



        public CreateRegistrationAppServices(IRepository<UpdateRegister> repository)
        {
            _repository = repository;
        }
        //public void createRegister(CreateRegister createRegister)
        //{
        //    var register = _repository.FirstOrDefault(x => x.FirstName == createRegister.FirstName);
        //    if(register!=null)
        //    {
        //       throw new UserFriendlyException("Data Exists");
        //    }
        //    register = new CreateRegister
        //    {
        //       // Id = createRegister.Id,
        //        FirstName = createRegister.FirstName,
        //        LastName = createRegister.LastName,
        //        Address = createRegister.Address,
        //        CreationTime = createRegister.CreationTime
        //    };
        //    _repository.Insert(register);
        //}

        public void updateRegister(UpdateRegister updateRegister,int id)
        {
            var register = _repository.FirstOrDefault(x => x.Id == id);
            if (register == null)
            {
                throw new UserFriendlyException("Data Exists");
            }
            register = new UpdateRegister
            {
                // Id = createRegister.Id,
                FirstName = updateRegister.FirstName,
                LastName = updateRegister.LastName,
                Address = updateRegister.Address,
                

            };
            _repository.Update(register);
        }
    }
}
