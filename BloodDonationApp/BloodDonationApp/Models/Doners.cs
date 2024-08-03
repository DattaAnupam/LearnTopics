﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationApp.Models
{
    public class Doners
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string? Mobile { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Email { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string? BloodGroup { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string? Address { get; set; }
    }
}
