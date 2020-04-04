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

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //MOVIMIENTO DE FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //private void BtnSide_Click(object sender, EventArgs e)
        //{
        //    if (MenuVertical.Width == 250)
        //    {
        //        MenuVertical.Width = 180;

        //    }
        //    else
        //        MenuVertical.Width = 250;
        //}
        // HORA A TIEMPO REAL
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            Ldlhora.Text = DateTime.Now.ToLongTimeString();
        }
        //MINIMIZAR Y CIERRE 
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //MOVIMIENTO DE FORMULARIO
        private void MenuVertical_Paint(object sender, PaintEventArgs e){}
        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e){}

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //LLAMAR FORM AL PANEL CONTENEDOR
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void BtnMatricula_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Matricula());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
 

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cursos());
        }

        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Estudiantes());
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            Lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void BtnaProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Profesores());
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Tools());
        }
    }
}
