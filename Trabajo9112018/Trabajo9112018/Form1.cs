using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo9112018.Model;

namespace Trabajo9112018
{
    public partial class Form1 : Form
    {
        private DAO_Cedula dc;
        private DAO_Nacionalidad dn;
        private DAO_Ciudad daoCiud;

        public Form1()
        {
            InitializeComponent();
            dc = new DAO_Cedula();
            dn = new DAO_Nacionalidad();
            daoCiud = new DAO_Ciudad();

            dataGridCedulas.DataSource = dc.Read();
            cboNacionalidad.DataSource = dn.Read();
            cboCiudadDeNacimiento.DataSource = daoCiud.Read();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String apellidos = txtApellidos.Text;
            String nombres = txtNombres.Text;
            




        }
    }
}
