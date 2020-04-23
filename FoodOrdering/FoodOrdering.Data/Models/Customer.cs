using System;
using System.ComponentModel.DataAnnotations;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Models
{
    public class Customer: IEntity
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}