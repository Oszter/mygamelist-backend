using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class Platform (string Name, string OperatingSystem, OperationalSystem OperationalSystem)
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = Name;

        [Required]
        [MaxLength(80)]
        public string OperatingSystem { get; set; } = OperatingSystem;

        [Required]
        public OperationalSystem OperationalSystem { get; set; } = OperationalSystem;

        [Required]
        public ICollection<Game> Game { get; set; }

    }
}