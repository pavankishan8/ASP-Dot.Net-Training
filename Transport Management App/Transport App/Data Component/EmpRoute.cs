//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportApp.Data_Component
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpRoute
    {
        public int EntryID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> PickUpID { get; set; }
        public Nullable<int> DropID { get; set; }
        public int Amount { get; set; }
    
        public virtual PickUpTable PickUpTable { get; set; }
        public virtual EmpTable EmpTable { get; set; }
        public virtual PickUpTable PickUpTable1 { get; set; }
    }
}
