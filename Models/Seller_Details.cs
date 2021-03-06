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
    
    public partial class Seller_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seller_Details()
        {
            this.Booking_Details = new HashSet<Booking_Details>();
            this.Property_Details = new HashSet<Property_Details>();
            this.Sold_Property = new HashSet<Sold_Property>();
        }
    
        public int Seller_Id { get; set; }
        public string Seller_Name { get; set; }
        public string Seller_Email { get; set; }
        public int Seller_Phone { get; set; }
        public string Seller_State { get; set; }
        public byte[] Seller_Photo { get; set; }
        public string Seller_Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Details> Booking_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Property_Details> Property_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sold_Property> Sold_Property { get; set; }
    }
}
