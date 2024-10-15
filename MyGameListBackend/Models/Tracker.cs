using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyGameList.Models
{
    public class Tracker
    {
        public int Id { get; set; }

        /// <summary>
        /// Category of tracker list. Example: Played, Playing, Dropped.
        /// </summary>
        [Required]
        public TrackerCategory TrackerCategory { get; set; }

        [Required]
        public ICollection<Game> Games { get; set; }
    }
}