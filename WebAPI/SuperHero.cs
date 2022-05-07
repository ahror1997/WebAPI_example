using System.ComponentModel.DataAnnotations;

namespace WebAPI
{
    public class SuperHero
    {
        public int Id { get; set; }
        
        [Required]
        public string Nickname { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsAlive { get; set; } = false;
    }
}
