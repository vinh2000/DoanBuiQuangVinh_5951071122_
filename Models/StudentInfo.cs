using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoanBuiQuangVinh_5951071122.Models
{    
    [DataContract]
        
    public class StudentInfo
    {
        [DataMember(Name = "TenSV")]
        public string TenSV { get; set; }
        [DataMember(Name = "MaSV")]
        public string MaSV { get; set; }
        [DataMember(Name = "Namsinh")]
        public int Namsinh { get; set; }
        [DataMember (Name ="Tuoi")]
        public int Tuoi { get; set; }
        
    }
}