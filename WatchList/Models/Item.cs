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

        public string? Description { get; set; }

        public Type SelectedItemType { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

    }
}
