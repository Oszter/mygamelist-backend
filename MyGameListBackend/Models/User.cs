using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(40)]
        public string Nickname { get; set; }

        [Required]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [MaxLength(80)]
        public string Password { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public ICollection<Game>? Games { get; set; }
    }
}