using System.ComponentModel.DataAnnotations.Schema;
using Wholesale.Domain.Common.Base;
using Wholesale.Domain.Entities.PRT;

namespace Wholesale.Domain.Entities.FCT
{
    public class InvoiceDetailEntity : BaseEntity
    {
        public float Count { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public int InvoiceHeader_Id { get; set; }
        [ForeignKey("InvoiceHeader_Id")]
        public InvoiceHeaderEntity InvoiceHeader { get; set; }

        public int Product_Id { get; set; }
        [ForeignKey("Product_Id")]
        public ProductEntity Product { get; set; }
    }
}