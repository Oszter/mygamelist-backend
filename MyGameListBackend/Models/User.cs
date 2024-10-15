using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class User(string name, string nickname, string email, string password, bool isActive, DateTime signUpSince, DateTime lastLogin, ICollection<Tracker> tracker)
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = name;

        [Required]
        [MaxLength(40)]
        public string Nickname { get; set; } = nickname;

        [Required]
        [MaxLength(80)]
        public string Email { get; set; } = email;

        [Required]
        [MaxLength(80)]
        public string Password { get; set; } = password;

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; } = isActive;

        [Required]
        public DateTime SignUpSince { get; set; } = signUpSince;

        public DateTime LastLogin { get; set; } = lastLogin;

        /// <summary>
        /// Relationship for EF Core, between mother User class and child Tracker class.
        /// </summary>
        [Required]
        public ICollection<Tracker> Tracker { get; set; } = tracker;
    }
}