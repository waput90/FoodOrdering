using System;
using System.ComponentModel.DataAnnotations.Schema;
using FoodOrdering.Data.Access.Common;
using Microsoft.AspNetCore.Identity;

namespace FoodOrdering.Data.Models
{
    [Table("AspNetUsers")]
    public class SystemUser: IdentityUser, IEntity
    {
        public DateTime DateCreated { get; set; }
    }
}