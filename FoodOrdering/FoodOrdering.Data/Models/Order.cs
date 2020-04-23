using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Order: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public decimal Total { get; set; }
        public decimal DiscountedTotal { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}