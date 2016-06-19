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
    }
}
