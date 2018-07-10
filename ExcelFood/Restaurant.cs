//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelFood
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurant()
        {
            this.CookOrders = new HashSet<CookOrder>();
            this.DailyMinutes = new HashSet<DailyMinute>();
            this.GuestGenerals = new HashSet<GuestGeneral>();
            this.MiniRestRequests = new HashSet<MiniRestRequest>();
            this.Person_Restaurant = new HashSet<Person_Restaurant>();
            this.PoonehReservations = new HashSet<PoonehReservation>();
            this.Res_Cont_Contract = new HashSet<Res_Cont_Contract>();
            this.Res_Cont_Contract_Restaurant = new HashSet<Res_Cont_Contract_Restaurant>();
            this.ReservationDayCounts = new HashSet<ReservationDayCount>();
            this.Schedules = new HashSet<Schedule>();
            this.TakeAwayDetails = new HashSet<TakeAwayDetail>();
            this.Units = new HashSet<Unit>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Nullable<int> Status_Id_Fk { get; set; }
        public Nullable<bool> IsMain { get; set; }
        public Nullable<int> Rc_Id { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
        public Nullable<int> ReferenceLunch_Id_Fk { get; set; }
        public Nullable<int> ReferenceDinner_Id_Fk { get; set; }
        public Nullable<int> ReferenceExtraMeal_Id_Fk { get; set; }
        public Nullable<int> ReferenceEftar_Id_Fk { get; set; }
        public Nullable<int> Company_Id_Fk { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CookOrder> CookOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyMinute> DailyMinutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuestGeneral> GuestGenerals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniRestRequest> MiniRestRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person_Restaurant> Person_Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoonehReservation> PoonehReservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Res_Cont_Contract> Res_Cont_Contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Res_Cont_Contract_Restaurant> Res_Cont_Contract_Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationDayCount> ReservationDayCounts { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TakeAwayDetail> TakeAwayDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit> Units { get; set; }
    }
}
