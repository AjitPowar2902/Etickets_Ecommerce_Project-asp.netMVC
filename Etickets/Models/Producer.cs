﻿using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; } 
        public string? ProfilePictureURL { get; set; }
        public string? FullName { get;set; }
        public string? Bio { get; set; }

        //Relationships
        List<Movie>? Movies { get; set; } 
    }
}