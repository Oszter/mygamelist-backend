using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class Genre(string name)
    {
        public int Id {get; set;}

        [Required]
        public string Name {get; set;} = name;

        [Required]
        public ICollection<Game> Game {get; set;}
    }
}