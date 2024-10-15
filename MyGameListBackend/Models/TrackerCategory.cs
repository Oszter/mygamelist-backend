using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class TrackerCategory
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
    }
}