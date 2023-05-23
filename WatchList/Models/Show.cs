using System.ComponentModel.DataAnnotations;

namespace WatchList.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
