using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class CATEGORY
    {
        [Key]
        public int CategoryID { get; set; }
        public string Category_Name { get; set; }
    }

}