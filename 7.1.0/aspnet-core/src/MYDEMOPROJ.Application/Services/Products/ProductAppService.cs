using Abp.Application.Services;
using Abp.Domain.Repositories;
using MYDEMOPROJ.Model;
using MYDEMOPROJ.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYDEMOPROJ.Services.Products
{
    public class ProductsAppService : CrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
