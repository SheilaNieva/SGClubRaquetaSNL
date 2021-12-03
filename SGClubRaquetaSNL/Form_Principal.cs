using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSNL
{
    public partial class Form_Principal : Form
    {
        Form_Adm_Pistas form_pistas = new Form_Adm_Pistas();
        Form_Adm_Socios form_socios = new Form_Adm_Socios();
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Manera de abrir un formulario emergente y modal
            form_socios.ShowDialog();
        }

        private void pistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Manera de abrir un formulario emergente y modal
            form_pistas.ShowDialog();
        }

        /*Cargamos este formulario dentro del formulario principal.
         * Para ello el padre debe tener la propiedad: isMdiContainer = true
         */
        private void tsMenuReservas_Click(object sender, EventArgs e)
        {
            Form_Reservas form_reservas = new Form_Reservas();
            form_reservas.MdiParent = this;
            form_reservas.Dock = DockStyle.Fill;
            form_reservas.Show();
        }

        //La opcion salir, cierra el formulario
        private void tsMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
