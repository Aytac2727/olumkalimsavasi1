//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFootballProject.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezerv
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Price { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
        public int CustomerId { get; set; }
        public int StadiumId { get; set; }
        public int RoomId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public virtual Stadion Stadion { get; set; }
    }
}
