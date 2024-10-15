using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyGameList.Models
{
    public class Genre
    {
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        [JsonIgnore]
        public ICollection<Game> Game {get; set;}
    }
}