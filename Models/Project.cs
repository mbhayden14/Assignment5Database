﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression("(\\d{3})-(\\d{10})")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
