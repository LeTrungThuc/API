using System.ComponentModel.DataAnnotations;

namespace Contacts_API.Models
{
    public class Transport
    {
        [Key]
        public Guid Id_DL { get; set; }
        public string Noti { get; set; }
        public string Transport_fee { get; set; }
        public string Shipping_fee { get; set;}
        public string Actual_weight { get; set; }
        public string converted_volume { get; set; }
        public int Ma_KMHCV { get; set; }
        public float COD { get; set; }
    }
}
