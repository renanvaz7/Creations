using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Creations
{
    public partial class btn_TelaLogin : Form
    {
        public btn_TelaLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txt_TelaInicial_User_Enter(object sender, EventArgs e)
        {
            if (txt_TelaInicial_User.Text == "Usuário")
            {
                txt_TelaInicial_User.Text = "";
                txt_TelaInicial_User.ForeColor = Color.CornflowerBlue;
            }
        }
        private void txt_TelaInicial_User_Leave(object sender, EventArgs e)
        {
            if (txt_TelaInicial_User.Text == "")
            {
                txt_TelaInicial_User.Text = "Usuário";
                txt_TelaInicial_User.ForeColor = Color.CornflowerBlue;
                txt_TelaInicial_User.UseSystemPasswordChar = false;
            }
        }
        private void txt_TelaInicial_Senha_Enter(object sender, EventArgs e)
        {
            if (txt_TelaInicial_Senha.Text == "Senha")
            {
                txt_TelaInicial_Senha.Text = "";
                txt_TelaInicial_Senha.ForeColor = Color.CornflowerBlue;
            }
        }
        private void txt_TelaInicial_Senha_Leave(object sender, EventArgs e)
        {
            if (txt_TelaInicial_Senha.Text == "")
            {
                txt_TelaInicial_Senha.Text = "Senha";
                txt_TelaInicial_Senha.ForeColor = Color.CornflowerBlue;
                txt_TelaInicial_Senha.UseSystemPasswordChar = false;
            }
        }

        private void btn_TelaInicial_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TelaInicial_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_TelaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
