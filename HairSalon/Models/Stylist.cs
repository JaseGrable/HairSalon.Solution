using System.Collections.Generic;

namespace Salon.Models
{
    public class Salon
    {
        public int SalonId { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
    }
}