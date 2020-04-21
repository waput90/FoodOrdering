using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Menu: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

    }
}