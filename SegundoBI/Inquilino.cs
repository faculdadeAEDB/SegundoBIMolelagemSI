//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegundoBI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inquilino
    {
        public Inquilino()
        {
            this.Alguel = new HashSet<Alguel>();
        }
    
        public string InqNome { get; set; }
        public int InqID { get; set; }
        public string InqEndereco { get; set; }
        public string InqBairro { get; set; }
        public string InqCidade { get; set; }
        public string InqTelefone { get; set; }
        public string InqCPF { get; set; }
    
        public virtual ICollection<Alguel> Alguel { get; set; }
    }
}
