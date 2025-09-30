using System.ComponentModel.DataAnnotations;

namespace CoreGymApi.Dtos
{
    public class AddSessionDto
    {
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Trainer { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Spots { get; set; }
    }
}
