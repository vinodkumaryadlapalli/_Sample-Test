using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.WebPages;
using Test_2022F.Attributes;

namespace Test_2022F.Models
{
    public class Book
    {
        // TestNote: Make the Title, Published and Edition required 
        // TestNote: Ensure each validation failure produces a visible validation result

        public int Id { get; set; }

        // TestNote: Restrict the Title to a maximum length of 100 characters
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime Published { get; set; }
        [Required]
        public int Edition { get; set; }

        // TestNote: Using IValidatableObject OR a ValidationAttribute, validate the ISBN property is 9, 10 or 13 digits.
        [ValidISBN]
        public string ISBN { get; set; }
       
    }
}
