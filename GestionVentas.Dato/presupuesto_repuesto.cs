//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVentas.Dato
{
    using System;
    using System.Collections.Generic;
    
    public partial class presupuesto_repuesto
    {
        public presupuesto_repuesto()
        {
            this.presupuesto_repuesto_desgloce = new HashSet<presupuesto_repuesto_desgloce>();
        }
    
        public int PK_ppto_repuesto_id { get; set; }
        public int Presupuesto { get; set; }
        public int Repuesto { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public int Valor_Unitario { get; set; }
        public int Sub_Total { get; set; }
        public int Hora_Par_Hombre { get; set; }
    
        public virtual ICollection<presupuesto_repuesto_desgloce> presupuesto_repuesto_desgloce { get; set; }
        public virtual presupuesto presupuesto1 { get; set; }
        public virtual repuesto repuesto1 { get; set; }
    }
}
