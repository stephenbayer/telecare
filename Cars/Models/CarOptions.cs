using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Models
{
    public class CarOptions
    {
        public Double Price {get; set;}
        public String Color {get; set;}
        public int SafetyRating { get; set; }
        public Dictionary<string, object> OtherOptions { get; set; }
    }
}
