using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using MyCompanyName.AbpZeroTemplate.Authorization;
using MyCompanyName.AbpZeroTemplate.List.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.List
{
    [DisableAuditing]
    [AbpAuthorize(AppPermissions.Pages_Customers)]
    public class CustomerAppService : AbpZeroTemplateAppServiceBase, ICustomerAppService
    {
        private readonly IRepository<Customer,long> _customerRepository;

        public CustomerAppService(IRepository<Customer,long> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ListResultDto<CustomerListDto> GetCustomer(GetCustomerInput input)
        {
            var people = _customerRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.CustomerName.Contains(input.Filter) ||
                         p.CustomerCode.Contains(input.Filter) ||
                         p.MailAddress.Contains(input.Filter)
                )
                .OrderBy(p => p.CustomerName)
                .ThenBy(p => p.CustomerCode)
                .ToList();
            return new ListResultDto<CustomerListDto>(ObjectMapper.Map<List<CustomerListDto>>(people));
        }
        public async Task CreateCustomer(CreateCustomerInput input)
        {
            var customer = ObjectMapper.Map<Customer>(input);
            await _customerRepository.InsertAsync(customer);
        }
        //[AbpAuthorize(AppPermissions.Pages_Customers_DeleteCustomer)]
        public async Task DeleteCustomer(EntityDto input)
        {
            await _customerRepository.DeleteAsync(input.Id);
        }
    }
}
