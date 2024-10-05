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
        public string? Name { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public string Poster { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<User>? Users { get; set; }
    }
}