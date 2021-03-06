using System;
using System.ComponentModel.DataAnnotations;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Menu: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}