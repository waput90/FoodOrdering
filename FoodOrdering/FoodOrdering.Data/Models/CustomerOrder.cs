using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class CustomerOrder: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string OrderRefId { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        public string CouponId { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer SystemUser { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}