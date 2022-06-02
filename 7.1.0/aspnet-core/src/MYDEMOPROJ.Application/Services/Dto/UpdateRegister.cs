using Abp.AutoMapper;
using Abp.Domain.Entities;
using MYDEMOPROJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYDEMOPROJ.Services.Dto
{
    [AutoMapTo(typeof(Registration))]
    public class UpdateRegister : Entity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime LastModificationTime { get; set; } = DateTime.Now;  
    }
}
