//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheFoody.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurant()
        {
            this.Restaurant_Type = new HashSet<Restaurant_Type>();
            this.Ratings = new HashSet<Rating>();
            this.Favourites = new HashSet<Favourite>();
            this.Menus = new HashSet<Menu>();
        }
    
        public int Id { get; set; }
        public string OwnerEmail { get; set; }
        public string RestaurantName { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostCode { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string CompanyBackground { get; set; }
        public System.TimeSpan OpeningTime { get; set; }
        public System.TimeSpan ClosingTime { get; set; }
        public System.TimeSpan DeliveryStartingTime { get; set; }
        public System.TimeSpan DeliveryEndingTime { get; set; }
        public string TimetakentoDeliver { get; set; }
        public Nullable<decimal> MinDelivery { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant_Type> Restaurant_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourite> Favourites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
