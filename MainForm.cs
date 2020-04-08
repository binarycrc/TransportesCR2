/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportesCR2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Creamos la instancia para la clase DataLayer
        /// </summary>
        DataLayer datalayer = new DataLayer();
        /// <summary>
        /// Constructor de MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que se produce antes de que se muestre el formulario por primera vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargaGridConductores(""); //Ejecucion del metodo para cargar el grid de conductores
                CargaGridCamiones(""); //Ejecucion del metodo para cargar el grid de camiones
                CargaGridConductorxCamion("");//Ejecucion del metodo para cargar el grid de conductorxcamiones
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre antes de que se cierre el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit(); //Cerramos completamente la aplicacion
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Procedimiento para validar el ingreso de valores decimales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void soloNumerosConPunto(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar)
                                || e.KeyChar == (char)Keys.Back
                                || e.KeyChar == '.'))
                { e.Handled = true; }
                TextBox txtDecimal = sender as TextBox;
                if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
                { e.Handled = true; }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton salir y cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit(); //Cerramos completamente la aplicacion
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }

        #region "Conductores"
        /// <summary>
        /// Evento que ocurre con el click en el boton Guardar Conductor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarConductor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //Cambiamos el tipo de cursor
            try
            {
                if ( //Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                       (string.IsNullOrEmpty(txtCedula.Text)) || (string.IsNullOrWhiteSpace(txtCedula.Text))
                    || (string.IsNullOrEmpty(txtNombre.Text)) || (string.IsNullOrWhiteSpace(txtNombre.Text))
                    || (string.IsNullOrEmpty(txtApellido1.Text)) || (string.IsNullOrWhiteSpace(txtApellido1.Text))
                    || (string.IsNullOrEmpty(txtApellido2.Text)) || (string.IsNullOrWhiteSpace(txtApellido2.Text))
                    || (string.IsNullOrEmpty(txtRutaAsignada.Text)) || (string.IsNullOrWhiteSpace(txtRutaAsignada.Text))
                    )
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos"; //si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    // Creamos la instancia para la clase Conductor
                    Conductor conductor = new Conductor(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtRutaAsignada.Text);
                    //if (!datalayer.GuardaConductor(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtRutaAsignada.Text))
                    if (!datalayer.GuardaConductor(conductor)) //Llamamos al evento para guardar el conductor
                    {
                        lblResultado.Text = datalayer._LatestError; //Cuando el resultado del ingreso es negativo desplegamos un mensaje
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError; //Desplegamos un mensaje cuando el ingreso es positivo
                        datalayer._LatestError = ""; //Limpiamos el valor de los mensajes en la clase DataLayer
                        LimpiaBoxesConductores(); //Limpiamos los textbox utilizados para la clace Conductor
                        CargaGridConductores(""); //Cargamos nuevamente el grid de conductores
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default; //Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Procedimiento para cargar los conductores en el grid 
        /// </summary>
        /// <param name="prmBuscar"></param>
        private void CargaGridConductores(string prmBuscar)
        {
            //Creamos la coleccion de tipo Conductor
            Dictionary<string, Conductor> Conductores = new Dictionary<string, Conductor>();
            gvConductores.DataSource = null; //Se limpia el origen de los datos para el grid
            try
            {
                Conductores = datalayer.GetConductores(prmBuscar); //Llamamos al metodo que devuelve una coleccion de tipo Conductor
                gvConductores.DataSource = Conductores.Values.ToList(); //Cargamos la coleccion al grid
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Procedimiento para limpiar los textbox de ingreso de conductores
        /// </summary>
        private void LimpiaBoxesConductores()
        {
            try
            {
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";
                txtRutaAsignada.Text = "";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Buscar Conductor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarConductores_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            try
            {
                //Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                if ((string.IsNullOrEmpty(txtBuscarConductores.Text)) || (string.IsNullOrWhiteSpace(txtBuscarConductores.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos"; //si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    CargaGridConductores(txtBuscarConductores.Text); //Cargamos nuevamente el grid de conductores segun el filtro
                    lblResultado.Text = datalayer._LatestError;//Desplegamos un mensaje cuando el ingreso es positivo
                    datalayer._LatestError = "";//Limpiamos el valor de los mensajes en la clase DataLayer
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default;//Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// cuando la tecla es enter llama al metodo Buscar Conductores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarConductores_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) { btnBuscarConductores_Click(this, new EventArgs()); }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Ver todos los Conductores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerConductores_Click(object sender, EventArgs e)
        {
            try
            {
                CargaGridConductores("");//Cargamos nuevamente el grid de conductores 
                txtBuscarConductores.Text = "";//Limpiamos el textbox
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        #endregion //"Conductores"

        #region "Camiones"
        /// <summary>
        /// Evento que ocurre con el click en el boton Guardar Camion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardaCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            try
            {
                if (//Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                       (string.IsNullOrEmpty(txtPlaca.Text)) || (string.IsNullOrWhiteSpace(txtPlaca.Text))
                    || (string.IsNullOrEmpty(numModelo.Text)) || (string.IsNullOrWhiteSpace(numModelo.Text))
                    || (string.IsNullOrEmpty(cbMarca.SelectedItem.ToString())) || (string.IsNullOrWhiteSpace(cbMarca.SelectedItem.ToString()))
                    || (string.IsNullOrEmpty(txtCapKilos.Text)) || (string.IsNullOrWhiteSpace(txtCapKilos.Text))
                    || (string.IsNullOrEmpty(txtCapVolumen.Text)) || (string.IsNullOrWhiteSpace(txtCapVolumen.Text))
                    )
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos"; //si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    // Creamos la instancia para la clase Camion
                    Camion camion = new Camion(txtPlaca.Text, numModelo.Text, cbMarca.SelectedItem.ToString(), txtCapKilos.Text, txtCapVolumen.Text);
                    //if (!datalayer.GuardaCamion(txtPlaca.Text, numModelo.Text, cbMarca.SelectedItem.ToString(), txtCapKilos.Text, txtCapVolumen.Text))
                    if (!datalayer.GuardaCamion(camion))
                    {
                        lblResultado.Text = datalayer._LatestError; //Cuando el resultado del ingreso es negativo desplegamos un mensaje
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;//Desplegamos un mensaje cuando el ingreso es positivo
                        datalayer._LatestError = "";//Limpiamos el valor de los mensajes en la clase DataLayer
                        LimpiaBoxesCamiones();//Limpiamos el grid de camiones
                        CargaGridCamiones("");//Cargamos nuevamente el grid de camiones
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default;//Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Procedimiento para cargar los camiones en el grid 
        /// </summary>
        /// <param name="prmBuscar"></param>
        private void CargaGridCamiones(string prmBuscar)
        {
            //Creamos la coleccion de tipo Camion
            Dictionary<string, Camion> Camiones = new Dictionary<string, Camion>();
            gvCamiones.DataSource = null; //Se limpia el origen de los datos para el grid
            try
            {
                Camiones = datalayer.GetCamiones(prmBuscar); //Llamamos al metodo que devuelve una coleccion de tipo Camion
                gvCamiones.DataSource = Camiones.Values.ToList(); //Cargamos la coleccion al grid
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Procedimiento para limpiar los textbox de ingreso de camiones
        /// </summary>
        private void LimpiaBoxesCamiones()
        {
            try
            {
                txtPlaca.Text = "";
                txtCapKilos.Text = "";
                txtCapVolumen.Text = "";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Buscar camion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCamiones_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            try
            {
                //Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                if ((string.IsNullOrEmpty(txtBuscarCamiones.Text)) || (string.IsNullOrWhiteSpace(txtBuscarCamiones.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos"; //si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    CargaGridCamiones(txtBuscarCamiones.Text); //Cargamos nuevamente el grid de camiones segun el filtro
                    lblResultado.Text = datalayer._LatestError; //Desplegamos un mensaje cuando el ingreso es positivo
                    datalayer._LatestError = "";//Limpiamos el valor de los mensajes en la clase DataLayer
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default;//Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// cuando la tecla es enter llama al metodo Buscar camion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void txtBuscarCamiones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) { btnBuscarCamiones_Click(this, new EventArgs()); }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Ver todos los camiones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerCamiones_Click(object sender, EventArgs e)
        {
            try
            {
                CargaGridCamiones("");
                txtBuscarCamiones.Text = "";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCapKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCapVolumen_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }
        #endregion //"Camiones"

        #region "ConductorxCamion"
        /// <summary>
        /// Procedimiento para cargar los conductores por camion en el grid
        /// </summary>
        /// <param name="prmBuscar"></param>
        private void CargaConductorxCamion(string prmBuscar)
        {
            LimpiaBoxesConductorxCamion(); //Limpiamos los textbox utilizados para la clace ConductorxCamion
            //Creamos la coleccion de tipo Conductor
            Dictionary<string, Conductor> Conductores = new Dictionary<string, Conductor>(); 
            try
            {
                Conductores = datalayer.GetConductorxCamion(prmBuscar); //Llamamos al metodo que devuelve una coleccion de tipo conductor
                foreach (Conductor conductor in Conductores.Values)
                {
                    //Mostramos los datos del conductor seleccionado
                    lblIdentificacionSeleccionado.Text = conductor.Identificacion;
                    lblNombreSeleccionado.Text = conductor.Nombre;
                    lblPApellidoSeleccionado.Text = conductor.PApellido;
                    lblRutaSeleccionado.Text = conductor.Ruta;
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Procedimiento para limpiar los textbox de ConductorxCamion
        /// </summary>
        private void LimpiaBoxesConductorxCamion()
        {
            try
            {
                lblIdentificacionSeleccionado.Text = "";
                lblNombreSeleccionado.Text = "";
                lblPApellidoSeleccionado.Text = "";
                lblRutaSeleccionado.Text = "";
                listbUnassigned.Items.Clear();
                listbAssigned.Items.Clear();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Buscar ConductorxCamion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarConductorxCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            LimpiaBoxesConductorxCamion(); //Limpiamos los textbox utilizados para la clace ConductorxCamion
            //Cambiamos el estilo del boton 
            btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Regular);
            btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Black;
            try
            {
                //Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                if ((string.IsNullOrEmpty(txtBuscarConductorSeleccionado.Text)) || (string.IsNullOrWhiteSpace(txtBuscarConductorSeleccionado.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";//si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    CargaConductorxCamion(txtBuscarConductorSeleccionado.Text); //Buscamos el conductor segun el filtro
                    CargaListbConductorxCamion(txtBuscarConductorSeleccionado.Text); 
                    lblResultado.Text = datalayer._LatestError; //Desplegamos un mensaje cuando el ingreso es positivo
                    datalayer._LatestError = ""; //Limpiamos el valor de los mensajes en la clase DataLayer
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default;//Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Procedimiento para cargas los ListBox de ConductorxCamion
        /// </summary>
        /// <param name="prmBuscar"></param>
        private void CargaListbConductorxCamion(string prmBuscar)
        {
            //Creamos la coleccion de tipo Camion
            Dictionary<string, string> ConductorxCamion = new Dictionary<string, string>();
            //Limpiamos ambos listbox
            listbUnassigned.Items.Clear(); 
            listbAssigned.Items.Clear();
            try
            {
                ConductorxCamion = datalayer.GetConductorxCamion(prmBuscar, 0); //Buscamos los camiones NO asignados al conductor
                foreach (var strcamion in ConductorxCamion.ToArray())
                {
                    //Agregamos cada camion en un formato especifico 
                    listbUnassigned.Items.Add(strcamion.Value.Trim());
                }
                ConductorxCamion = datalayer.GetConductorxCamion(prmBuscar, 1); //Buscamos los camiones ASIGNADOS al conductor
                foreach (var strcamion in ConductorxCamion.ToArray())
                {
                    //Agregamos cada camion en un formato especifico 
                    listbAssigned.Items.Add(strcamion.Value.Trim());
                }
                //Cambiamos el estilo del boton 
                btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Regular);
                btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento para mover simular mover items entre los listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoverDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                //Si existen items seleccionado en el listbox
                if (listbUnassigned.Items.Count > 0 && listbUnassigned.SelectedItem != null)
                {
                    //para todos los items en el listbox de camiones NO asignados
                    for (int i = 0; i < listbUnassigned.Items.Count; i++)
                    {
                        //Si esta seleccionado lo agregamos en el otro listbox
                        if (listbUnassigned.GetSelected(i))
                        {
                            listbAssigned.Items.Add(listbUnassigned.Items[i]);
                        }
                    }
                    //para todos los items en el listbox de camiones ASIGNADOS
                    for (int i = 0; i < listbUnassigned.Items.Count; i++)
                    {
                        //Si esta seleccionado lo removemos
                        if (listbUnassigned.GetSelected(i))
                        {
                            listbUnassigned.Items.Remove(listbUnassigned.Items[i]);
                        }
                    }
                    //Cambiamos el estilo del boton 
                    btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Bold);
                    btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento para mover simular mover items entre los listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoverIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                //Si existen items seleccionado en el listbox
                if (listbAssigned.Items.Count > 0 && listbAssigned.SelectedItem != null)
                {
                    //para todos los items en el listbox de camiones ASIGNADOS
                    for (int i = 0; i < listbAssigned.Items.Count; i++)
                    {
                        //Si esta seleccionado lo agregamos en el otro listbox
                        if (listbAssigned.GetSelected(i))
                        {
                            listbUnassigned.Items.Add(listbAssigned.Items[i]);
                        }
                    }
                    //para todos los items en el listbox de camiones ASIGNADOS
                    for (int i = 0; i < listbAssigned.Items.Count; i++)
                    {
                        //Si esta seleccionado lo removemos
                        if (listbAssigned.GetSelected(i))
                        {
                            listbAssigned.Items.Remove(listbAssigned.Items[i]);
                        }
                    }
                    //Cambiamos el estilo del boton 
                    btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Bold);
                    btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Guardar ConductorxCamion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarConductorxCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            try
            {
                //Borramos todos los camiones asignados al conductor
                datalayer.BorrarConductorxCamion(lblIdentificacionSeleccionado.Text.Trim());
                //Para cada item del listbox de camiones ASIGNADOS
                for (int i = 0; i < listbAssigned.Items.Count; i++)
                {
                    //Llamamos al evento para guardar el ConductorxCamion
                    if (!datalayer.GuardaConductorxCamion(lblIdentificacionSeleccionado.Text.Trim(), listbAssigned.Items[i].ToString().Split('/')[0].Trim()))
                    {
                        lblResultado.Text = datalayer._LatestError;//Cuando el resultado del ingreso es negativo desplegamos un mensaje
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;//Desplegamos un mensaje cuando el ingreso es positivo
                        datalayer._LatestError = "";//Limpiamos el valor de los mensajes en la clase DataLayer
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.Default;//Cambiamos el tipo de cursor
            //Cambiamos el estilo del boton 
            btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Regular);
            btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Black;

        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// cuando la tecla es enter llama al metodo Buscar Conductor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarConductorSeleccionado_KeyDown(object sender, KeyEventArgs e)
        {
            LimpiaBoxesConductorxCamion();
            //Cambiamos el estilo del boton 
            btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Regular);
            btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Black;
            try
            {
                if (e.KeyCode == Keys.Enter) { btnBuscarConductorxCamion_Click(this, new EventArgs()); }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Procedimiento para cargar los conductores en el grid 
        /// </summary>
        /// <param name="prmBuscar"></param>
        private void CargaGridConductorxCamion(string prmBuscar)
        {
            //Creamos la coleccion de tipo Conductor
            List<ConductorxCamion> conductorxcamiones = new List<ConductorxCamion>();
            gvConductorxCamion.DataSource = null; //Se limpia el origen de los datos para el grid
            try
            {
                conductorxcamiones = datalayer.GetConductorxCamiones(prmBuscar); //Llamamos al metodo que devuelve una coleccion de tipo Conductor
                gvConductorxCamion.DataSource = conductorxcamiones; //Cargamos la coleccion al grid
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento para buscar conductorxcamion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrarCamionesxConductor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
            try
            {
                //Validamos que los campos de texto no sean nulos, vacios o espacios en blanco
                if ((string.IsNullOrEmpty(txtBuscarConductorxCamion.Text)) || (string.IsNullOrWhiteSpace(txtBuscarConductorxCamion.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos"; //si existe algun valor invalido se muestra un mensaje
                }
                else
                {
                    CargaGridConductorxCamion(txtBuscarConductorxCamion.Text); //Cargamos nuevamente el grid de conductores segun el filtro
                    lblResultado.Text = datalayer._LatestError;//Desplegamos un mensaje cuando el ingreso es positivo
                    datalayer._LatestError = "";//Limpiamos el valor de los mensajes en la clase DataLayer
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
            Cursor.Current = Cursors.WaitCursor;//Cambiamos el tipo de cursor
        }
        /// <summary>
        /// Evento que ocurre con el click en el boton Ver todos los Conductores x Camion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerTodosCamionesxConductor_Click(object sender, EventArgs e)
        {
            try
            {
                CargaGridConductorxCamion("");//Cargamos nuevamente el grid de conductores 
                txtBuscarConductorxCamion.Text = "";//Limpiamos el textbox
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Evento que ocurre con las teclas accionadas en el textbox
        /// cuando la tecla es enter llama al metodo Buscar Conductores x camion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarConductorxCamion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter) { btnVerTodosCamionesxConductor_Click(this, new EventArgs()); }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message; //si existe algun error se muestra un mensaje
            }
        }
        #endregion //"ConductorxCamion"
    }
}
