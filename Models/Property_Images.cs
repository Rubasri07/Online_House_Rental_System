//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace House_Rental_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property_Images
    {
        public int img_id { get; set; }
        public byte[] Image { get; set; }
        public int Property_Id { get; set; }
    
        public virtual Property_Details Property_Details { get; set; }
    }
}
