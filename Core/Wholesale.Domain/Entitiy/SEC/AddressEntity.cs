using System;
using System.ComponentModel.DataAnnotations.Schema;
using Wholesale.Domain.Common.Base;

namespace Wholesale.Domain.Entities.SEC
{
    public class AddressEntity : BaseEntity
    {
        public AddressEntity() { }

        public string Address { get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }

        //TODO: use geography dataType for ef
        public string Lat { get; set; }
        public string Lng { get; set; }

        [ForeignKey("User_Id")]
        public UserEntity User { get; set; }
        public Guid User_Id { get; set; }

    }
}
