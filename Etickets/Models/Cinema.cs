using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Relationships
        List<Movie>? Movies { get; set; }
    }
}
