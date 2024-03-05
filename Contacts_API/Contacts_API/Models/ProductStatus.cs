using System.ComponentModel.DataAnnotations;

namespace Contacts_API.Models
{
    public class ProductStatus
    {
        [Key]
        public Guid Id_PrST { get; set; }
        public string Status {  get; set; }
        public string Actual_process { get; set; }

        public string System_process { get; set; }
        public string Inventory { get; set; }
    }
}
