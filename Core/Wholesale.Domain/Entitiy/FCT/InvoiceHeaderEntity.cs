using System;
using System.ComponentModel.DataAnnotations.Schema;
using Wholesale.Domain.Common.Base;
using Wholesale.Domain.Entities.SEC;
using Wholesale.Domain.Enum.FCT;

namespace Wholesale.Domain.Entities.FCT
{
    public class InvoiceHeaderEntity : BaseEntity
    {

        public int InvoiceCode { get; set; }

        public bool IsFinaly { get; set; }

        public RequestLevel RequestLevel { get; set; }

        [ForeignKey("User_Id")]
        public UserEntity User { get; set; }
        public Guid User_Id { get; set; }

        [ForeignKey("Address_Id")]
        public AddressEntity Address { get; set; }
        public Guid Address_Id { get; set; }
    }
}

