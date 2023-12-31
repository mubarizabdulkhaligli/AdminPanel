﻿using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Book>? Books { get; set; }
    }
}
