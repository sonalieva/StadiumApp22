using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumApp2.Data.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Stadionid { get; set; }
        public int Userid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
