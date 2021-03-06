//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BucksSafePlaceSite2.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Incident
    {
        
        public int IncidentID { get; set; }
        public string IncidentTitle { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string IncidentLocation { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public Nullable<System.DateTime> IncidentDate { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(10, ErrorMessage = "Max length 10 characters")]
        public string Tag { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Report { get; set; }

    }
}
