using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaSNL
{
    public partial class Form_Reservas : Form
    {
        //Declaramos el dataSet
        dsBD dsBD = new dsBD();
        //Declaracion de array que va a contener los id de los socios en el orden alfabetico por apellido
        ArrayList ListaIdSocios = new ArrayList();
        //Array que va a tener los id de las pistas
        ArrayList ListaIdPista = new ArrayList();
        public Form_Reservas()
        {
            InitializeComponent();
            //Enlazamos el datagridview con la tabla que vamos a mostrar en él
            dgvReservas.DataSource = dsBD.reservas;
            //Ocultamos las columnas que no queremos mostrar de primeras en el dgv
            ocultarColumnas();

            cargarSocios();
            cargarPistas();
        }

        /*Cargamos un combobox a pelo
         * Hacemos una consulta a la tabla pistas para recoger toda la informacion
         * Recorremos esa lista y vamos añadiendo el nombre de cada item(pista) al combobox de pistas
         */
        private void cargarPistas()
        {
            dsBDTableAdapters.pistasTableAdapter taPistas = new dsBDTableAdapters.pistasTableAdapter();
            taPistas.Fill(dsBD.pistas);

            for (int i = 0; i < dsBD.pistas.Count; i++)
            {
                cbPista.Items.Add(dsBD.pistas[i].nombre);
                ListaIdPista.Add(dsBD.pistas[i].idPista);
            }
        }

        /*Cuando se cargue este formulario debemos rellenar el combobox de socios en el orden: apellidos,nombre
         Para eso necesitamos un for, que lo vaya rellenando según la consulta que hemos hecho
        y a su vez en un arrayList metemos sus ids correspondientes*/
        private void cargarSocios()
        {
            dsBDTableAdapters.sociosTableAdapter taSocios = new dsBDTableAdapters.sociosTableAdapter();
            taSocios.FillByApellidosNombre(dsBD.socios);//consulta que recoge nombre, apellido, id

            for (int i = 0; i < dsBD.socios.Count; i++)
            {
                cbSocio.Items.Add(dsBD.socios[i].apellidos + ", " + dsBD.socios[i].nombre);
                ListaIdSocios.Add(dsBD.socios[i].DNI);
            }
        }

        /*Ocultamos las columnas en el datagridview que no vayamos a necesitar*/
        private void ocultarColumnas()
        {
            dgvReservas.Columns[0].Visible = false;
            dgvReservas.Columns[4].Visible = false;
        }


        //Cuando elegimos algo en el combobox
        private void cbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hacemos una consulta ordenando por apellido, nombre
            dsBDTableAdapters.sociosTableAdapter taSocios = new dsBDTableAdapters.sociosTableAdapter();
            taSocios.FillByApellidosNombre(dsBD.socios);
            int indice = cbSocio.SelectedIndex;

            //Recorremos el array con los dni de los socios
            for (int i = 0; i < ListaIdSocios.Count; i++)
            {
                //Si el indice del combobox del socio que hemos seleccionado coincide con el dni del socio que vamos
                //recorriendo con el for
                if(i == indice)
                {
                    //Rellenamos los campos de ese socio [i]
                    tbNombre.Text = dsBD.socios[i].nombre;
                    tbApellido.Text = dsBD.socios[i].apellidos;
                    mtbTelefono.Text = dsBD.socios[i].telefono;
                    tbDireccion.Text = dsBD.socios[i].domicilio;
                    tbEmail.Text = dsBD.socios[i].email;
                    mtbCCC.Text = dsBD.socios[i].cuentaCorriente;

                    //Rellenamos el dni del socio
                    labelDniSocio.Text = dsBD.socios[i].DNI;
                }
            }
            actualizarReservas();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            //Comprueba si ese socio tiene alguna reserva sin pagar
            bool impagos = false;
            impagos = comprobarPistasPagadas();

            //Si hay algun impago mostramos un mensaje (y no va a dejar reservar)
            if (impagos)
            {
                MessageBox.Show("Este usuario tiene reservas sin pagar");
            }
            //si todo esta pagado, comprobamos que esta libre esa pista a la hora que nosotros queremos
            else {
                comprobarFecha(); 
                
            }
            actualizarReservas();

        }

        private void hacerReserva()
        {
            int pista = int.Parse(ListaIdPista[cbPista.SelectedIndex].ToString());
            String hora = nupHora.Value.ToString() + ":" + nupMinutos.Value.ToString() + ":00";
            TimeSpan formHora = DateTime.Parse(hora).TimeOfDay;

            //Hacemos un insert en la tabla reservas, para crear una nueva reserva con la fecha deseadam la hora, la pista
            //el dni del socio, indicamos que no esta pagada, y su precio (q por defecto he puesto 15)
            dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
            taReservas.Insert(System.DateTime.Parse(dtpFecha.Text), formHora, pista, labelDniSocio.Text, "No", 15);
            MessageBox.Show("Reserva hecha");
            
        }

        private void comprobarFecha()
        {
            dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
            //Si el combobox de pista no esta vacio
            if (!cbPista.Text.Equals(""))
            {
                bool reservada = false;
                String hora = nupHora.Value.ToString() + ":" + nupMinutos.Value.ToString() + ":00";
                TimeSpan formHora = DateTime.Parse(hora).TimeOfDay;

                int pista = int.Parse(ListaIdPista[cbPista.SelectedIndex].ToString());

                taReservas.FillByFecha(dsBD.reservas, dtpFecha.Text, pista);
                
                //Si existe alguna reserva ese dia
                if (dsBD.reservas.Count > 0)
                {
                    //Recorro todas las reservas y compruebo que no coincida el horario
                    for (int i = 0; i < dsBD.reservas.Count; i++)
                    {
                        TimeSpan horaBD = dsBD.reservas[i].hora;
                        TimeSpan resultado = (formHora - horaBD);
                        if (Math.Abs(resultado.Hours) < 1)
                        {
                            reservada = true;
                        }else if (Math.Abs(resultado.Hours) >= 2)
                        {
                            reservada = false;
                        }else if (Math.Abs(resultado.Minutes) >= 30)
                        {
                            //Si solo hay una hora de diferencia en el intervalo
                            //se mira que haya 30min o mas de espacio en el intervalo
                            reservada = false;
                        }
                        else
                        {
                            reservada = true;
                        }

                    }
                        //Si no esta reservada a es ahora, podemos reservarla
                    if (reservada == false)
                    {
                        hacerReserva();
                    }
                    //Si hay alguna reserva ese dia y a esa hora, mostramos un mensaje
                    else
                    {
                        MessageBox.Show("Ese dia y a esa hora no se puede reservar esa pista");
                    }
                }
                //Si no hay ninguna reserva con esa fecha, hacemos reserva
                else
                {
                    hacerReserva();
                }
            }
        }
        //Hacemos una consulta para comprobar que ese usuario no tiene reservas sin pagar
        private bool comprobarPistasPagadas()
        {
            Boolean impagos = false;
            dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
            taReservas.FillByReservaNoPagada(dsBD.reservas, labelDniSocio.Text);

            //Si esta consulta devuelve algun registro, quiere decir que tenemos reservas sin pagar
            if(dsBD.reservas.Count > 0)
            {
                impagos = true;
            }
            return impagos;
        }

        //Cambiamos la foto del picturebox segun vayamos cambiando la pista en el combobox ( y segun lo que haya guardado en la bbdd)
        private void cbPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsBDTableAdapters.pistasTableAdapter taPistas = new dsBDTableAdapters.pistasTableAdapter();
            taPistas.Fill(dsBD.pistas);
            
            pbFoto.Image = byteArrayToImage(dsBD.pistas[cbPista.SelectedIndex].foto);

        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream ms = new MemoryStream(bytesArr);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Si hay alguna fila seleccionada en el dgv
            if(dgvReservas.SelectedRows.Count > 0)
            {
                //Comprobamos que la celda de pagado, este a 'si'
                if (dgvReservas.SelectedRows[0].Cells[5].Value.ToString().Equals("Si"))
                {
                    MessageBox.Show("Esta reserva ya está pagada");
                }
                //Si esta a no, podemos pagar esa reserva haciendo un update en la tabla reservas y cambiando 
                //el valor de la columna 'pagado' a 'si'
                else
                {
                    int idReserva = int.Parse(dgvReservas.SelectedRows[0].Cells[0].Value.ToString());
                    dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
                    taReservas.ActualizarPago(idReserva);

                    actualizarReservas();

                    
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila");
            }
        }

        //Actualizamos el dgv, con una consulta nueva en la tabla de reservas cada vez que se llame a este metodo(que es cada vez que hay un cambio)
        private void actualizarReservas()
        {
            int indice = cbSocio.SelectedIndex;
            string dniSocio = (string)ListaIdSocios[indice];
            dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
            taReservas.FillBySocio(dsBD.reservas, dniSocio);
            dgvReservas.DataSource = dsBD.reservas;
        }
    }
}
