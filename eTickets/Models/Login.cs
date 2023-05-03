using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTickets.Models
{
    public class Login
    {
        [Key]
        public string? EmailAddress { get; set; }

        public string? Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool IsRemember { get; set; }
    }
}
