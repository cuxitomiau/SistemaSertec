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
    
    public partial class presupuesto_trabajo_resumen
    {
        public presupuesto_trabajo_resumen()
        {
            this.presupuesto_trabajo_resumen_comercial_detalle = new HashSet<presupuesto_trabajo_resumen_comercial_detalle>();
            this.presupuesto_trabajo_resumen_comision_detalle = new HashSet<presupuesto_trabajo_resumen_comision_detalle>();
            this.presupuesto_trabajo_resumen_mo_detalle = new HashSet<presupuesto_trabajo_resumen_mo_detalle>();
        }
    
        public int PK_Presupuesto_Trabajo_Resumen_id { get; set; }
        public int Presupuesto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Total_Neto_Comsiones { get; set; }
    
        public virtual presupuesto presupuesto1 { get; set; }
        public virtual ICollection<presupuesto_trabajo_resumen_comercial_detalle> presupuesto_trabajo_resumen_comercial_detalle { get; set; }
        public virtual ICollection<presupuesto_trabajo_resumen_comision_detalle> presupuesto_trabajo_resumen_comision_detalle { get; set; }
        public virtual ICollection<presupuesto_trabajo_resumen_mo_detalle> presupuesto_trabajo_resumen_mo_detalle { get; set; }
    }
}
