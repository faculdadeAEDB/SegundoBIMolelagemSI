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
    
    public partial class Imovel
    {
        public Imovel()
        {
            this.Alguel = new HashSet<Alguel>();
        }
    
        public int ImoID { get; set; }
        public string ImoTipo { get; set; }
        public string ImoEndereco { get; set; }
        public string ImoBairro { get; set; }
        public string ImoCidade { get; set; }
        public int ImoIDPro { get; set; }
    
        public virtual ICollection<Alguel> Alguel { get; set; }
        public virtual Proprietario Proprietario { get; set; }
    }
}
