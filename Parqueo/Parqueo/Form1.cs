using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parqueo.Utilidades;

namespace Parqueo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Obtener los datos del formulario (Texto plano)
            string usuario = txtUsuario.Text;
        

            // 2. >>> PASO DE SEGURIDAD: Generar el Hash de la contraseña
            string contrasenaHash = Seguridad.HashContrasena(txtContrasena.Text);

            // 3. Instanciar la DAL
            UsuarioDAL dal = new UsuarioDAL();

            // 4. Autenticar, ENVIANDO EL HASH (contrasenaHash)
            // Ya no envías la variable 'contrasena' (plana), sino 'contrasenaHash' (segura)
            Reply r = dal.Autenticar(usuario, contrasenaHash);

            if (r.Ok)
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show(r.Mensaje, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
