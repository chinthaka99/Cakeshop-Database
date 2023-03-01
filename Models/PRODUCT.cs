using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class PRODUCT
    {
        [Key]
        public int ProductID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }

}
