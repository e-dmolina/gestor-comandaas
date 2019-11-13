//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorDeComandas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordenes()
        {
            this.DetallesOrden = new HashSet<DetallesOrden>();
        }
    
        public int id { get; set; }
        public decimal total { get; set; }
        public string observacion { get; set; }
        public int id_cliente { get; set; }
        public int id_domicilio { get; set; }
        public int id_estado { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesOrden> DetallesOrden { get; set; }
        public virtual Domicilios Domicilios { get; set; }
        public virtual Estados Estados { get; set; }
    }
}