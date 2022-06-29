using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.List.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.List
{
    public interface ICustomerAppService : IApplicationService
    {
        ListResultDto<CustomerListDto> GetCustomer(GetCustomerInput input);
        Task CreateCustomer(CreateCustomerInput input);
        Task DeleteCustomer(EntityDto input);
    }
}
