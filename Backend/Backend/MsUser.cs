using System.ComponentModel.DataAnnotations;

namespace Backend
{
    public class MsUser
    {
        [Key]
        public string Userid { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
