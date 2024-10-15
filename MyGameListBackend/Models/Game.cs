using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyGameList.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(180)]
        public string Name { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public string Poster { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public ICollection<Genre> Genres { get; set; }

        [Required]
        public ICollection<Platform> Platforms { get; set; }

        [Required]
        [JsonIgnore]
        public ICollection<Tracker> Trackers { get; set; }
    }
}