using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class PAYMENT
    {
        [Key]
        public int PaymentID { get; set; }
        public string Payment_Method { get; set; }
        public string Payment_Details { get; set; }
    }

}