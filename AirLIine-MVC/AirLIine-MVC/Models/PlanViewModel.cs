using System;

namespace AirLIine_MVC.Models
{
    public class PlanViewModel
    {
        public int Id { get; set; }
        public string NameAirline { get; set; }
        public string Mabda { get; set; }
        public string maghsad { get; set; }
        
        public DateTime tarikh { get; set; }
        public string Starikh { get; set; }
        public DateTime saat { get; set; }
        public string Ssaat { get; set; }
        public int zarfiat { get; set; } 
    }
}