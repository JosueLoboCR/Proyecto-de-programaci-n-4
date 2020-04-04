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
using Domain;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        //MOVIMIENTO DEL FORMULARIO 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TxtUser_TextChanged(object sender, EventArgs e) {}
        //MINIMIZAR Y CIERRE 
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == ""){
                TxtUser.Text = "Username";
                TxtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e){}

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPass.Text == ""){
                TxtPass.Text = "Password";
                TxtPass.ForeColor = Color.DimGray;
                TxtPass.UseSystemPasswordChar = false;
            }

        }
        private void lineShape1_Click(object sender, EventArgs e)  { }
   
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {}

        private void FormLogin_Load(object sender, EventArgs e) {}
        //INTERACION DE LOS TXT
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Username")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Password")
            {
                TxtPass.Text = "";
                TxtPass.ForeColor = Color.LightGray;
                TxtPass.UseSystemPasswordChar = true;
            }
        }
        //MOVIMIENTO DE FORMULARIO
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //VALIDACION DE ACCESSO
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text != "Username")
            {
                if (TxtUser.Text != "Username" && TxtUser.TextLength > 2)
                {
                    if (TxtPass.Text != "Password")
                    {

                        var valirpass = TxtPass.Text;
                        var valiruser = TxtUser.Text;
                        if (valirpass == "admin" && valiruser == "lobo") {
                                this.Hide();
                            Bienvenida welcome = new Bienvenida();
                                welcome.ShowDialog();
                            Menu abrir = new Menu();
                            abrir.Show();
                            abrir.FormClosed += Logout;
                        }
                        else
                        {
                            msgError("Incorrect username or password entered. \n   Please try again.");
                            TxtPass.Text = "Password";
                            TxtPass.UseSystemPasswordChar = false;
                            TxtUser.Focus();
                        }
                    }
                    else msgError("Please enter password.");
                }
                else msgError("Please enter username.");
            }
        }

        private void msgError(string msg)
        {
            LblError.Text = " " + msg;
            LblError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtPass.Text = "Password";
            TxtPass.UseSystemPasswordChar = false;
            TxtUser.Text = "Username";
            LblError.Visible = false;
            this.Show();

        }
    }
}
