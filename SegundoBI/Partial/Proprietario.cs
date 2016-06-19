using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoBI
{
    public partial class Proprietario
    {
        public void incluir()
        {
            Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities();
            oDB.Proprietario.Add(this);
            oDB.SaveChanges();
            oDB.Dispose();
        }

        public void alterar()
        {
            using (Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities())
            {
                oDB.Entry(this).State = System.Data.Entity.EntityState.Modified;
            }
        }
    }
}
