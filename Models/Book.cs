﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^\d{3}([-])\d{10}$")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Pages { get; set; }
    }
}
