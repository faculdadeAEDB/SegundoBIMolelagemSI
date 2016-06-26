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

        public static void Excluir(int Codigo)
        {
            using (Sistema_ImoveisEntities oDB = new Sistema_ImoveisEntities())
            {
                Proprietario oProprietario = new Proprietario();
                oDB.Entry(oProprietario).State = System.Data.Entity.EntityState.Deleted;
                oDB.Proprietario.Remove(oProprietario);
                oDB.SaveChanges();
            }
        }
    }
}
