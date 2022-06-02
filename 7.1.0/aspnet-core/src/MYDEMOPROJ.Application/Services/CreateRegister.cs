using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MYDEMOPROJ.Model;

namespace MYDEMOPROJ.Services
{
    [AutoMapTo(typeof(Registration))]
    public class CreateRegister : CreationAuditedEntity
    {
        //public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
