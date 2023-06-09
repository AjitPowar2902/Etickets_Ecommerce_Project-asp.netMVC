﻿using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name ="Logo")]
        public string? Logo { get; set; }
        [Display(Name = "Cinema Logo")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationships
        List<Movie>? Movies { get; set; }
    }
}
