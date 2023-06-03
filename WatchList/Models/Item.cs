using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WatchList.Models
{
    public enum ItemType
    {
        Book = 1,
        Film = 2,
        Show = 3
    }

    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [DisplayName("Type")]
        public ItemType SelectedItemType { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public double? Rating { get; set; }

    }
}
