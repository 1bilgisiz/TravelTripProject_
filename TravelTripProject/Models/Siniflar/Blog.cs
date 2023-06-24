using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Blog
    {
        public int ID { get; set; } 
        public string Baslik { get; set; }
        public DateTime tarih { get; set; }
        public String Aciklama { get; set; }
        public string BlogImage { get; set; }   

        public ICollection<Yorumlar> Yorumlars { get; set;}
    }
}