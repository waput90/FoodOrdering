using System;
using System.ComponentModel.DataAnnotations;
using FoodOrdering.Commons.Enums;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Coupon: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public CouponEnum? IsUsed { get; set; }
        public DateTime Validity { get; set; }
        public DateTime DateCreated { get; set; }
    }
}