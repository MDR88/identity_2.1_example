using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthSample.Models
{
    // Add profile data for application users by adding properties to the WebApp1User class
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [Required]
        [Display(Name ="Pet Name")]
        public string PetName { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
