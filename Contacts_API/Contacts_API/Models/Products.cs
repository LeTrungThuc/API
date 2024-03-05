using System.ComponentModel.DataAnnotations;

namespace Contacts_API.Models
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Day { get; set; }
        public string Customers { get; set; }
        public string Order_Status { get; set; }
        public Boolean Pay { get; set; }
        public Boolean Delivery { get; set; }
        public float COD { get; set; }
        public float Total { get; set; }
        public string Channel { get; set; }
        public Boolean Operation { get; set; }
        public int Product_ID { get; set;}

    }
}
