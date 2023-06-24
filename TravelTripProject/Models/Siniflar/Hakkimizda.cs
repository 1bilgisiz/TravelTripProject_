using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public String FotoUrl { get; set; }
        public DateTime tarih { get; set; }
        public String Aciklama { get; set; }
        public String BlogImage { get; set; }
    }
}