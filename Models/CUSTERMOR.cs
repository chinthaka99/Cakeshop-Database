using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class CUSTERMOR
    {
        [Key]
        public int CustermorID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }

}
