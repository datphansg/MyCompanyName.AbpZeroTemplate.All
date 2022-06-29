using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.List.Dto
{
    public class CustomerDto : EntityDto
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGroup { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string MailAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Notes { get; set; }
        public string TotalPayment { get; set; }
        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
    }
}
