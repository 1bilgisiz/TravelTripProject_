using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public String Aciklama { get; set; }
        public String AdresAcikhali { get; set; }
        public String Mail { get; set; }
        public String Telefon { get; set; }
        public String Konum { get; set; }
    }
}