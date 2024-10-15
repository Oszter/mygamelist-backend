using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyGameList.Models
{
    public class OperationalSystem
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

    }
}