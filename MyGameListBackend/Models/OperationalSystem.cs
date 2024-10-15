using System.ComponentModel.DataAnnotations;

namespace MyGameList.Models
{
    public class OperationalSystem (string Name)
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = Name;
        
        [Required]
        public Platform Plataform { get; set; }

    }
}