//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyClase02.Models.Conection
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_TipoDocumento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_TipoDocumento()
        {
            this.tb_Cliente = new HashSet<tb_Cliente>();
            this.tb_Colaborador = new HashSet<tb_Colaborador>();
        }
    
        public int idTipoDocumento { get; set; }
        public string nombreTipoDocumento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Cliente> tb_Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Colaborador> tb_Colaborador { get; set; }
    }
}
