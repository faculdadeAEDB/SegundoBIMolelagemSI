using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoBI;

namespace SegundoBI.views
{
    public partial class frmProprietario : Form
    {
        public frmProprietario()
        {
            InitializeComponent();
        }

        private void btnProVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImovel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmImoveis()).ShowDialog();
            this.Visible = true;
        }

        private void frmProprietario_Load(object sender, EventArgs e)
        {
            Sistema_ImoveisEntities dc = new Sistema_ImoveisEntities();
            var prop = from Proprietario in dc.Proprietario select Proprietario;
            grdProprietario.DataSource = prop.ToList();
        }

        private void btnProNovo_Click(object sender, EventArgs e)
        {
            Proprietario oProprietario = new Proprietario();
            oProprietario.Imovel = null;
            oProprietario.ProBairro = txbBairroPro.Text;
            oProprietario.ProCidade = txbCidadePro.Text;
            oProprietario.ProCPF = txbCPFPro.Text;
            oProprietario.ProEndereco = txbEnderecoPro.Text;
            oProprietario.ProNome = txbNomePro.Text;
            oProprietario.ProTelefone = txbTelefonePro.Text;

        }

        private void btnProSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
