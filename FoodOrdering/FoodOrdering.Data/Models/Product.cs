using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Product : IEntity
    {
        [Key]
        public string Id { get; set; }
        public string MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}