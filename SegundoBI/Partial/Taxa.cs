using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoBI
{
    public partial class Taxa
    {
        public void Incluir()
        {
            Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities();
            oDB.Taxa.Add(this);
            oDB.SaveChanges();
            oDB.Dispose();
        }

        public void Alterar()
        {
            using (Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities())
            {
                oDB.Entry(this).State = System.Data.Entity.EntityState.Modified;
                oDB.SaveChanges();
            }
        }

        public static void Excluir(int Codigo)
        {
            using (Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities())
            {
                Taxa oTaxa = new Taxa();
                oDB.Entry(oTaxa).State = System.Data.Entity.EntityState.Deleted;
                oDB.Taxa.Remove(oTaxa);
                oDB.SaveChanges();
            }
        }
    }
}
