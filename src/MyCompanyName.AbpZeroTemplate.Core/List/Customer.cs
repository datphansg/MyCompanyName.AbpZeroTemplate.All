using Abp;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MyCompanyName.AbpZeroTemplate.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.List
{
    [Table("AbpCustomer")]
    public class Customer : Entity<long>, IHasCreationTime, IMayHaveTenant
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
        public Customer(
            string customerCode,
            string customerName,
            string customerGroup,
            string address,
            string zipCode,
            string mailAddress,
            string phone1,
            string phone2,
            string notes,
            string totalPayment)
        {
            CustomerCode = customerCode;
            CustomerName = customerName;
            CustomerGroup = customerGroup;
            Address = address;
            ZipCode = zipCode;
            MailAddress = mailAddress;
            Phone1 = phone1;
            Phone2 = phone2;
            Notes = notes;
            TotalPayment = totalPayment;
            CreationTime = Clock.Now;
        }
        protected Customer()
        {

        }
    }
}
