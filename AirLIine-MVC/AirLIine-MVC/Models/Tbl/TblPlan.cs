using System;

namespace AirLIine_MVC.Models
{
    public class TblPlan
    {
        public int Id { get; set; }
        public string NameAirline { get; set; }
        public string Mabda { get; set; }
        public string maghsad { get; set; }
        
        public DateTime tarikh { get; set; }
        
        public int zarfiat { get; set; } 
    }
}