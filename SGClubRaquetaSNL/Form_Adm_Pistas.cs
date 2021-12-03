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
    public partial class Form_Adm_Pistas : Form
    {
        public Form_Adm_Pistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void Form_Adm_Pistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsBD.pistas);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Esperamos una confirmacion del usuario para poder borrar una pista
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("¿Estas seguro que desea borrar esta pista?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resp == DialogResult.Yes)
            {
                //Miramos si la pista esta reservada, consultado en la tabla reservas por el id de la pista
                dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
                taReservas.FillByPeliculaReservada(dsBD.reservas, int.Parse(idPistaLabel1.Text));

                //Si esto da mayor que 1 es que hemos encontrado alguna reserva en esa pista con ese id
                if (dsBD.reservas.Count > 0)
                {
                    MessageBox.Show("Esta pista está reservada, no se puede eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None); ;
                }
                //Sino borramos la pista sin ningun problema
                else
                {
                    dsBDTableAdapters.pistasTableAdapter taPistas = new dsBDTableAdapters.pistasTableAdapter();
                    taPistas.Delete(int.Parse(idPistaLabel1.Text));

                    MessageBox.Show("Pista eliminada");

                    //Se recargan las pistas
                    dsBD.pistas.Clear();
                    taPistas.Fill(dsBD.pistas);
                }
            }
        }

        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            ofdFoto.Filter = "Image files|*.jpg;*.png;*.gif;*.ico;.*;";
            if(ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofdFoto.FileName);
            }
        }
    }
}
