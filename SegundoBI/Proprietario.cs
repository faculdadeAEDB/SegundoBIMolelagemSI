//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegundoBI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proprietario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proprietario()
        {
            this.Imovel = new HashSet<Imovel>();
        }
    
        public string ProNome { get; set; }
        public int ProID { get; set; }
        public string ProEndereco { get; set; }
        public string ProBairro { get; set; }
        public string ProCidade { get; set; }
        public string ProTelefone { get; set; }
        public string ProCPF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imovel> Imovel { get; set; }
    }
}
