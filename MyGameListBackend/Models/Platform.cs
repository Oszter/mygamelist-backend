using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyGameList.Models
{
    public class Platform
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public OperationalSystem OperationalSystem { get; set; }

        [Required]
        [JsonIgnore]
        public ICollection<Game> Game { get; set; }

    }
}