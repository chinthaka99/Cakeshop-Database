using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Cakeshop.Models
{
    public class ADMINISTRATOR
    {
        [Key]
        public int AdministratorID { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
