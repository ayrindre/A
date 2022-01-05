using System;
using System.ComponentModel.DataAnnotations;

namespace AirLIine_MVC.Models
{

    public class TblReservation
    {
        [Key]
        public int Id { get; set; }
        
        
        public int UserId { get; set; }
        
        public int PlanId { get; set; }
 
    }

}