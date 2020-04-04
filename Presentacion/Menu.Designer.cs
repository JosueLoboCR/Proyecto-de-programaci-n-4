namespace Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnaProfesores = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnEstudiantes = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.BtnMatricula = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Lblfecha = new System.Windows.Forms.Label();
            this.Ldlhora = new System.Windows.Forms.Label();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(68)))), ((int)(((byte)(141)))));
            this.MenuVertical.Controls.Add(this.BtnLogout);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.BtnaProfesores);
            this.MenuVertical.Controls.Add(this.BtnAdmin);
            this.MenuVertical.Controls.Add(this.BtnEstudiantes);
            this.MenuVertical.Controls.Add(this.BtnCursos);
            this.MenuVertical.Controls.Add(this.BtnMatricula);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(179, 484);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.Location = new System.Drawing.Point(35, 422);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(100, 50);
            this.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnaProfesores
            // 
            this.BtnaProfesores.FlatAppearance.BorderSize = 0;
            this.BtnaProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnaProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnaProfesores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnaProfesores.ForeColor = System.Drawing.Color.White;
            this.BtnaProfesores.Image = ((System.Drawing.Image)(resources.GetObject("BtnaProfesores.Image")));
            this.BtnaProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnaProfesores.Location = new System.Drawing.Point(-1, 218);
            this.BtnaProfesores.Name = "BtnaProfesores";
            this.BtnaProfesores.Size = new System.Drawing.Size(180, 40);
            this.BtnaProfesores.TabIndex = 6;
            this.BtnaProfesores.Text = "Profesores";
            this.BtnaProfesores.UseVisualStyleBackColor = true;
            this.BtnaProfesores.Click += new System.EventHandler(this.BtnaProfesores_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.FlatAppearance.BorderSize = 0;
            this.BtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.Image")));
            this.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmin.Location = new System.Drawing.Point(0, 310);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(179, 40);
            this.BtnAdmin.TabIndex = 5;
            this.BtnAdmin.Text = "Tools";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnEstudiantes
            // 
            this.BtnEstudiantes.FlatAppearance.BorderSize = 0;
            this.BtnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstudiantes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.BtnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstudiantes.Image")));
            this.BtnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstudiantes.Location = new System.Drawing.Point(-1, 172);
            this.BtnEstudiantes.Name = "BtnEstudiantes";
            this.BtnEstudiantes.Size = new System.Drawing.Size(180, 40);
            this.BtnEstudiantes.TabIndex = 3;
            this.BtnEstudiantes.Text = "Estudiantes";
            this.BtnEstudiantes.UseVisualStyleBackColor = true;
            this.BtnEstudiantes.Click += new System.EventHandler(this.BtnEstudiantes_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.ForeColor = System.Drawing.Color.White;
            this.BtnCursos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCursos.Image")));
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 264);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(179, 40);
            this.BtnCursos.TabIndex = 2;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.UseVisualStyleBackColor = true;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // BtnMatricula
            // 
            this.BtnMatricula.FlatAppearance.BorderSize = 0;
            this.BtnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMatricula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatricula.ForeColor = System.Drawing.Color.White;
            this.BtnMatricula.Image = ((System.Drawing.Image)(resources.GetObject("BtnMatricula.Image")));
            this.BtnMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMatricula.Location = new System.Drawing.Point(-1, 126);
            this.BtnMatricula.Name = "BtnMatricula";
            this.BtnMatricula.Size = new System.Drawing.Size(179, 40);
            this.BtnMatricula.TabIndex = 0;
            this.BtnMatricula.Text = "Matricula ";
            this.BtnMatricula.UseVisualStyleBackColor = true;
            this.BtnMatricula.Click += new System.EventHandler(this.BtnMatricula_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.Lblfecha);
            this.BarraTitulo.Controls.Add(this.Ldlhora);
            this.BarraTitulo.Controls.Add(this.BtnMinimizar);
            this.BarraTitulo.Controls.Add(this.BtnMaximizar);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(179, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1058, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Lblfecha
            // 
            this.Lblfecha.AutoSize = true;
            this.Lblfecha.BackColor = System.Drawing.Color.White;
            this.Lblfecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfecha.ForeColor = System.Drawing.Color.DimGray;
            this.Lblfecha.Location = new System.Drawing.Point(6, 16);
            this.Lblfecha.Name = "Lblfecha";
            this.Lblfecha.Size = new System.Drawing.Size(68, 22);
            this.Lblfecha.TabIndex = 5;
            this.Lblfecha.Text = "Fecha";
            this.Lblfecha.Click += new System.EventHandler(this.Lblfecha_Click);
            // 
            // Ldlhora
            // 
            this.Ldlhora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ldlhora.AutoSize = true;
            this.Ldlhora.BackColor = System.Drawing.Color.White;
            this.Ldlhora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldlhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Ldlhora.Location = new System.Drawing.Point(464, 9);
            this.Ldlhora.Name = "Ldlhora";
            this.Ldlhora.Size = new System.Drawing.Size(68, 30);
            this.Ldlhora.TabIndex = 4;
            this.Ldlhora.Text = "Hora";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(965, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(26, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(997, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(26, 25);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1029, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(26, 25);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(179, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1058, 434);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelContenedor_MouseDown);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 484);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1237, 484);
            this.MinimumSize = new System.Drawing.Size(1237, 484);
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label Ldlhora;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnaProfesores;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnEstudiantes;
        private System.Windows.Forms.Button BtnCursos;
        private System.Windows.Forms.PictureBox BtnLogout;
        private System.Windows.Forms.Button BtnMatricula;
        private System.Windows.Forms.Label Lblfecha;
        private System.Windows.Forms.Timer Fecha;
    }
}