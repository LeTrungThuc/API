using System.ComponentModel.DataAnnotations;

namespace Contacts_API.Models
{
    public class Customer
    {
        [Key]
        public Guid Id_CT { get; set; }
        public string Channel { get; set; }
        public string Fullname { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
