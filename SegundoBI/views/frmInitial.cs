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
    public partial class frmInitial : Form
    {
        public frmInitial()
        {
            InitializeComponent();
        }

        private void btnCadPro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmProprietario()).ShowDialog();
            this.Visible = true;
        }

        private void btnCadInq_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmInquilino()).ShowDialog();
            this.Visible = true;
        }

        private void btnLocação_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmImoveis()).ShowDialog();
            this.Visible = true;
        }
    }
}
