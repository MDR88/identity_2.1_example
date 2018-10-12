using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthSample.Models
{
    // Add profile data for application users by adding properties to the WebApp1User class
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [Display(Name ="Provider")]
        public string Provider { get; set; }

        [Required]
        [Display(Name ="Account number")]
        public string AccountNumber { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
