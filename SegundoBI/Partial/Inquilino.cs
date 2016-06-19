using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoBI
{
    public partial class Inquilino
    {
        public void Incluir()
        {
            Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities();
            oDB.Inquilino.Add(this);
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
                Inquilino oInquilino = new Inquilino();
                oDB.Entry(oInquilino).State = System.Data.Entity.EntityState.Deleted;
                oDB.Inquilino.Remove(oInquilino);
                oDB.SaveChanges();
            }
        }

    }
}
