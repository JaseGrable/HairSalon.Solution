using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Salon
    {
        public int SalonId { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
    }
}