using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class ORDER
    {
        [Key]
        public int OrderID { get; set; }
        public int Total_Cost { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Order_Time { get; set; }
    }

}