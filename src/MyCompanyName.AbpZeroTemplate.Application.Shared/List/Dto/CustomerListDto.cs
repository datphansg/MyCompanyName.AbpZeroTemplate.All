using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.List.Dto
{    
    public class CustomerListDto : FullAuditedEntityDto
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGroup { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string MailAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Notes { get; set; }
    }
}
