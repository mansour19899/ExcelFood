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
    
    public partial class Person_IdentifyInfo
    {
        public int Id { get; set; }
        public Nullable<int> Person_Id_Fk { get; set; }
        public Nullable<int> IdentifyInfo_Id_Fk { get; set; }
        public Nullable<int> restaurant_id_fk { get; set; }
        public Nullable<System.DateTime> PoonehArchived { get; set; }
    
        public virtual IdentifyInfo IdentifyInfo { get; set; }
        public virtual Person Person { get; set; }
    }
}