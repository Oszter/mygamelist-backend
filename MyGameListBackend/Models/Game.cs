using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class Game(string name, string summary, int score, string poster, DateTime releaseDate)
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(180)]
        public string Name { get; set; } = name;

        [Required]
        public string Summary { get; set; } = summary;

        [Required]
        public int Score { get; set; } = score;

        [Required]
        public string Poster { get; set; } = poster;

        [Required]
        public DateTime ReleaseDate { get; set; } = releaseDate;

        [Required]
        public ICollection<Genre> Genre { get; set; }

        [Required]
        public ICollection<Platform> Platform { get; set; }
    }
}