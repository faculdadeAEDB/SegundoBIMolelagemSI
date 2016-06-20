using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoBI.views
{
    public partial class frmImoveis : Form
    {
        public frmImoveis()
        {
            InitializeComponent();
        }

        private void ImoBtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImoveis_Load(object sender, EventArgs e)
        {
            Sistema_ImoveisEntities dc = new Sistema_ImoveisEntities();
            var imo = from Imovel in dc.Imovel join Proprietario in dc.Proprietario on Imovel.ImoIDPro equals Proprietario.ProID select Imovel;
            dgvImo.DataSource = imo.ToList();
        }
    }
}
