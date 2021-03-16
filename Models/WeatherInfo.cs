using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoanBuiQuangVinh_5951071122.Models
{   
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name ="location")]
        public string Location { get; set; }
        [DataMember(Name ="degree")]
        public float Degree { get; set; }
        [DataMember(Name ="dateTime")]
        public DateTime DateTime { get; set; }
    }
}