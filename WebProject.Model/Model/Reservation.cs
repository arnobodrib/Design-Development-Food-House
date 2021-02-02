using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Model.Model
{
    public class Reservation
    {
        public int ReserveID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Datetime { get; set; }
        public string Message { get; set; }

        
    }
}
