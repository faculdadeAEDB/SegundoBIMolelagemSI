using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoBI
{
    public partial class Imovel
    {
        public void Incluir()
        {
            Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities();
            oDB.Dispose();
        }
    }
}
