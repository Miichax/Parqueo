namespace Parqueo
{
    partial class FrmMantenimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texContrasena = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.CboRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrarCampos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Parqueo.Properties.Resources.Icono_cerrar_FN;
            this.btnCerrar.Location = new System.Drawing.Point(167, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(73, 50);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(292, 120);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(122, 22);
            this.texNombre.TabIndex = 11;
            this.texNombre.TextChanged += new System.EventHandler(this.texNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de Usuario";
            // 
            // texContrasena
            // 
            this.texContrasena.Location = new System.Drawing.Point(283, 191);
            this.texContrasena.Name = "texContrasena";
            this.texContrasena.PasswordChar = '*';
            this.texContrasena.Size = new System.Drawing.Size(122, 22);
            this.texContrasena.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña de Usuario";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(257, 270);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(452, 150);
            this.DgvUsuarios.TabIndex = 21;
            // 
            // CboRol
            // 
            this.CboRol.FormattingEnabled = true;
            this.CboRol.Items.AddRange(new object[] {
            "Administrador",
            "Tecnico",
            "Usuarios Publicos"});
            this.CboRol.Location = new System.Drawing.Point(540, 110);
            this.CboRol.Name = "CboRol";
            this.CboRol.Size = new System.Drawing.Size(119, 24);
            this.CboRol.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rol";
            // 
            // btnBorrarCampos
            // 
            this.btnBorrarCampos.FlatAppearance.BorderSize = 0;
            this.btnBorrarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnBorrarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCampos.ForeColor = System.Drawing.Color.White;
            this.btnBorrarCampos.Image = global::Parqueo.Properties.Resources.delete;
            this.btnBorrarCampos.Location = new System.Drawing.Point(0, 270);
            this.btnBorrarCampos.Name = "btnBorrarCampos";
            this.btnBorrarCampos.Size = new System.Drawing.Size(161, 59);
            this.btnBorrarCampos.TabIndex = 20;
            this.btnBorrarCampos.Text = "Borrar campos";
            this.btnBorrarCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarCampos.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Parqueo.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(0, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 59);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.FlatAppearance.BorderSize = 0;
            this.btnActulizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnActulizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActulizar.ForeColor = System.Drawing.Color.White;
            this.btnActulizar.Image = global::Parqueo.Properties.Resources.actualizar;
            this.btnActulizar.Location = new System.Drawing.Point(0, 140);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(161, 59);
            this.btnActulizar.TabIndex = 18;
            this.btnActulizar.Text = "Actualizar usuario";
            this.btnActulizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActulizar.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = global::Parqueo.Properties.Resources.guardar;
            this.btnUsuario.Location = new System.Drawing.Point(0, 75);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(161, 59);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "Guardar usuario";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.btnBorrarCampos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.texContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMantenimiento";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox texContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarCampos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.ComboBox CboRol;
        private System.Windows.Forms.Label label3;
    }
}