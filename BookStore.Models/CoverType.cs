﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class CoverType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Cover Type")]
        public string? Name { get; set; }
    }
}
