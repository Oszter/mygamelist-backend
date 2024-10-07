using System;
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
        public string Name { get; set; }

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

        [Required]
        public DateTime SignUpSince { get; set; }

        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Relationship for EF Core, between mother User class and child Tracker class.
        /// </summary>
        [Required]
        public ICollection<Tracker> Tracker { get; set; }
    }
}