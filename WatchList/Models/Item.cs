using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WatchList.Models
{
    public enum Type
    {
        Book,
        Film,
        Show
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
        public Type SelectedItemType { get; set; }

        //[Display(Name = "Created Date")]
        //public DateTime CreatedDate = DateTime.Now;

    }
}
