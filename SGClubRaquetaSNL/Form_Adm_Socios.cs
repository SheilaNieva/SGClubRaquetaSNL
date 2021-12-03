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
    public partial class Form_Adm_Socios : Form
    {
        public Form_Adm_Socios()
        {
            InitializeComponent();
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Compruebo que no haya ningun campo vacio, que el telefono tenga un longitud de 9 digitos y la cc de 28
                if (!tbDni.Text.Equals(string.Empty) && !tbNombre.Text.Equals(string.Empty)
                    && !tbApellidos.Text.Equals(string.Empty) && !tbDomicilio.Text.Equals(string.Empty)
                    && mtbTelefono.Text.Length==9 && !tbEmail.Text.Equals(string.Empty)
                    && mtbCuentaCorriente.Text.Length==28)
                {
                    //creo un objeto de la tabla socios
                    socios objSocio = new socios();
                    //Asocio todos los datos que haya en los textbox a los campos de la tabla socios
                    objSocio.DNI = tbDni.Text;
                    objSocio.nombre = tbNombre.Text;
                    objSocio.apellidos = tbApellidos.Text;
                    objSocio.domicilio = tbDomicilio.Text;
                    objSocio.telefono = mtbTelefono.Text;
                    objSocio.email = tbEmail.Text;
                    objSocio.cuentaCorriente = mtbCuentaCorriente.Text;

                    //al objeto de la bbdd añado el objeto socio que acabamos de crear con los nuevos datos
                    objBD.socios.Add(objSocio);

                    //Guardamos los cambios en el objeto de la bbd
                    objBD.SaveChanges();
                    MessageBox.Show("Se ha insertado el socio correctamente");
                    //limpiamos el formulario
                    limpiarDatos();
                }
                //Si hay algun campo vacio o no rellenado correctamente, lo indicamos por pantalla al usuario
                else
                {
                    MessageBox.Show("Debes rellenar todos los campos correctamente", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            using(clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Hacemos una consulta a la tabla socios y mostramos todos sus datos en el dgv
                var consulta = from soc in objBD.socios
                               select new
                               {
                                   soc.DNI,
                                   soc.nombre,
                                   soc.apellidos,
                                   soc.domicilio,
                                   soc.telefono,
                                   soc.email,
                                   soc.cuentaCorriente
                               };

                
                dgvSocios.DataSource = consulta.ToList();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using(clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Consultamos la tabla socios a ver si encontramos un registro que contenga un usuario con ese DNI y lo metemos en un objeto de la tabla socios
                socios objSocios = objBD.socios.Find(tbDni.Text);

                //Si ese objeto no esta vacio
                if(objSocios != null)
                {
                    //Consulta que nos devuelve las reservas (idReservas) de ese usuario
                    var consultaReserva = from res in objBD.reservas
                                          where res.socio.Equals(tbDni.Text)
                                          select res.idReserva;

                    var listaConsulta = consultaReserva.ToList();

                    //Si exiten reservas, ese socio no puede eliminarse
                    if (listaConsulta.Count>0)
                    {
                        MessageBox.Show("Este socio no se puede borrar debido a que tiene reservas", "¡ERROR!,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //sino, lo eliminamos
                    else
                    {
                        //en el obj de la bbdd eliminamos el objeto socio
                        objBD.socios.Remove(objSocios);

                        //Guardamos los cambios
                        objBD.SaveChanges();

                        MessageBox.Show("Socio eliminado correctamente");

                        //Limpiamos el formulario
                        limpiarDatos();
                    }
                }
                //La consulta no ha devuelto nada, con lo cual ese socio no esta registrado en la tabla socios
                else
                {
                    MessageBox.Show("No se encuentra ese socio");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Buscamos un socio en la tabla socios con ese dni, y lo metemos en un objeto socio
                socios objSocio = objBD.socios.Find(tbDni.Text);

                //Si ese objeto no esta vacio
                if(objSocio != null)
                {
                    //Comprobamos que todos los campos esten escritos o rellenados correctamente
                    if (!tbNombre.Text.Equals(string.Empty)
                    && !tbApellidos.Text.Equals(string.Empty) && !tbDomicilio.Text.Equals(string.Empty)
                    && mtbTelefono.Text.Length == 9 && !tbEmail.Text.Equals(string.Empty)
                    && mtbCuentaCorriente.Text.Length == 28)
                    {
                        //Asociamos la informacion de los txtbox en los campos del objeto socio
                        objSocio.DNI = tbDni.Text;
                        objSocio.nombre = tbNombre.Text;
                        objSocio.apellidos = tbApellidos.Text;
                        objSocio.domicilio = tbDomicilio.Text;
                        objSocio.telefono = mtbTelefono.Text;
                        objSocio.email = tbEmail.Text;
                        objSocio.cuentaCorriente = mtbCuentaCorriente.Text;

                        //Guardamdos los cambios en el objeto de la bbdd
                        objBD.SaveChanges();
                        MessageBox.Show("Se ha modificado el socio correctamente");

                        //Limpiamos el formulario
                        limpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Debes rellenar todos los campos correctamente", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        //Vacia todos los textbox y masktexbox
        private void limpiarDatos()
        {
            tbDni.Text = "";
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbDomicilio.Text = "";
            mtbTelefono.Text = "";
            tbEmail.Text = "";
            mtbCuentaCorriente.Text = "";
        }

    }
}
