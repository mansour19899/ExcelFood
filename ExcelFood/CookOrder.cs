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
    
    public partial class CookOrder
    {
        public int Id { get; set; }
        public Nullable<int> Tray_Id_Fk { get; set; }
        public Nullable<int> Meal_Id_Fk { get; set; }
        public Nullable<int> Restaurant_Id_Fk { get; set; }
        public Nullable<int> PorsNo { get; set; }
        public string CDate { get; set; }
        public Nullable<int> Contractor_Id_Fk { get; set; }
        public Nullable<int> Res_Cont_Contract_Id_Fk { get; set; }
    
        public virtual Contractor Contractor { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual Res_Cont_Contract Res_Cont_Contract { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Tray Tray { get; set; }
    }
}
