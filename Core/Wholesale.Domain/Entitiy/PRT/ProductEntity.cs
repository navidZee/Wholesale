using System;
using System.ComponentModel.DataAnnotations.Schema;
using Wholesale.Domain.Common.Base;

namespace Wholesale.Domain.Entities.PRT
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public byte Discount { get; set; }
        public string ImageNames { get; set; } //json format

        [ForeignKey("Category_Id")]
        public CategoryEntity Category { get; set; }
        public Guid Category_Id { get; set; }
    }
}
