using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creations
{
    public partial class btn_TelaInicial_Cadastro : Form
    {
        public btn_TelaInicial_Cadastro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TelaInicial_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm_TelaIncial = new frm_Cadastrar();
            frm_TelaIncial.Closed += (s, args) => this.Close();
            frm_Cadastrar.Show();
        }
    }
}
