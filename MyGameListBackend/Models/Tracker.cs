using System.Collections;
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

        /// <summary>
        /// Relationship for EF Core, between child Tracker class and mother User class.
        /// </summary>
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
    }
}