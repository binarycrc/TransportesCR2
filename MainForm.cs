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
        DataLayer datalayer = new DataLayer();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CargaGridConductores("");
            CargaGridCamiones("");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void soloNumerosConPunto(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back 
                || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {e.Handled = true;}
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region "Conductores"
        private void btnGuardarConductor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (
                       (string.IsNullOrEmpty(txtCedula.Text)) || (string.IsNullOrWhiteSpace(txtCedula.Text))
                    || (string.IsNullOrEmpty(txtNombre.Text)) || (string.IsNullOrWhiteSpace(txtNombre.Text))
                    || (string.IsNullOrEmpty(txtApellido1.Text)) || (string.IsNullOrWhiteSpace(txtApellido1.Text))
                    || (string.IsNullOrEmpty(txtApellido2.Text)) || (string.IsNullOrWhiteSpace(txtApellido2.Text))
                    || (string.IsNullOrEmpty(txtRutaAsignada.Text)) || (string.IsNullOrWhiteSpace(txtRutaAsignada.Text))
                    )
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    if (!datalayer.GuardaConductor(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtRutaAsignada.Text))
                    {
                        lblResultado.Text = datalayer._LatestError;
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;
                        datalayer._LatestError = "";
                        LimpiaBoxesConductores();
                        CargaGridConductores("");
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void CargaGridConductores(string prmBuscar)
        {
            Dictionary<string, Conductor> Conductores = new Dictionary<string, Conductor>();
            gvConductores.DataSource = null;
            try
            {
                Conductores = datalayer.GetConductores(prmBuscar);
                gvConductores.DataSource = Conductores.Values.ToList();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
        }
        private void LimpiaBoxesConductores()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtRutaAsignada.Text = "";
        }
        private void btnBuscarConductores_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if ((string.IsNullOrEmpty(txtBuscarConductores.Text)) || (string.IsNullOrWhiteSpace(txtBuscarConductores.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    CargaGridConductores(txtBuscarConductores.Text);
                    lblResultado.Text = datalayer._LatestError;
                    datalayer._LatestError = "";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void txtBuscarConductores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){ btnBuscarConductores_Click(this, new EventArgs());}
        }
        private void btnVerConductores_Click(object sender, EventArgs e)
        {
            CargaGridConductores("");
        }
        #endregion //"Conductores"

        #region "Camiones"
        private void btnGuardaCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (
                       (string.IsNullOrEmpty(txtPlaca.Text)) || (string.IsNullOrWhiteSpace(txtPlaca.Text))
                    || (string.IsNullOrEmpty(numModelo.Text)) || (string.IsNullOrWhiteSpace(numModelo.Text))
                    || (string.IsNullOrEmpty(cbMarca.SelectedItem.ToString())) || (string.IsNullOrWhiteSpace(cbMarca.SelectedItem.ToString()))
                    || (string.IsNullOrEmpty(txtCapKilos.Text)) || (string.IsNullOrWhiteSpace(txtCapKilos.Text))
                    || (string.IsNullOrEmpty(txtCapVolumen.Text)) || (string.IsNullOrWhiteSpace(txtCapVolumen.Text))
                    )
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    if (!datalayer.GuardaCamion(txtPlaca.Text, numModelo.Text, cbMarca.SelectedItem.ToString(), txtCapKilos.Text, txtCapVolumen.Text))
                    {
                        lblResultado.Text = datalayer._LatestError;
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;
                        datalayer._LatestError = "";
                        LimpiaBoxesCamiones();
                        CargaGridConductores("");
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void CargaGridCamiones(string prmBuscar)
        {
            Dictionary<string, Camion> Camiones = new Dictionary<string, Camion>();
            gvCamiones.DataSource = null;
            try
            {
                Camiones = datalayer.GetCamiones(prmBuscar);
                gvCamiones.DataSource = Camiones.Values.ToList();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
        }
        private void LimpiaBoxesCamiones()
        {
            txtPlaca.Text = "";
            txtCapKilos.Text = "";
            txtCapVolumen.Text = "";
        }
        private void btnBuscarCamiones_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if ((string.IsNullOrEmpty(txtBuscarCamiones.Text)) || (string.IsNullOrWhiteSpace(txtBuscarCamiones.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    CargaGridCamiones(txtBuscarCamiones.Text);
                    lblResultado.Text = datalayer._LatestError;
                    datalayer._LatestError = "";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void txtBuscarCamiones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnBuscarCamiones_Click(this, new EventArgs()); }
        }
        private void btnVerCamiones_Click(object sender, EventArgs e)
        {
            CargaGridCamiones("");
        }
        private void txtCapKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }
        private void txtCapVolumen_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }
        #endregion //"Camiones"
        private void CargaConductorxCamion(string prmBuscar)
        {
            Dictionary<string, Conductor> Conductores = new Dictionary<string, Conductor>();
            lblIdentificacionSeleccionado.Text = "";
            lblNombreSeleccionado.Text = "";
            lblPApellidoSeleccionado.Text = "";
            lblRutaSeleccionado.Text = "";
            try
            {
                Conductores = datalayer.GetConductores(prmBuscar);
                //gvConductores.DataSource = Conductores.Values.ToList();
                foreach (Conductor conductor in Conductores.Values)
                {
                    //listbUnassigned.Items.Add(kvp.Value.Trim());
                    lblIdentificacionSeleccionado.Text = conductor.Identificacion;
                    lblNombreSeleccionado.Text = conductor.Nombre;
                    lblPApellidoSeleccionado.Text = conductor.PApellido;
                    lblRutaSeleccionado.Text = conductor.Ruta;
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
        }
        private void btnBuscarConductorxCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if ((string.IsNullOrEmpty(txtBuscarConductorSeleccionado.Text)) || (string.IsNullOrWhiteSpace(txtBuscarConductorSeleccionado.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    CargaConductorxCamion(txtBuscarConductorSeleccionado.Text);
                    CargaListbConductorxCamion(txtBuscarConductorSeleccionado.Text, 0);
                    lblResultado.Text = datalayer._LatestError;
                    datalayer._LatestError = "";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void CargaListbConductorxCamion(string prmBuscar, int prmAssigned)
        {
            Dictionary<string, string> Camiones = new Dictionary<string, string>();
            listbUnassigned.Items.Clear();
            try
            {
                Camiones = datalayer.GetConductorxCamion(prmBuscar, prmAssigned);
                //listbUnassigned.DataSource = new BindingSource(Camiones, null);
                //listbUnassigned.DisplayMember = "Value";
                //listbUnassigned.ValueMember = "Key";

                foreach (var kvp in Camiones.ToArray())
                {
                    listbUnassigned.Items.Add(kvp.Value.Trim());
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
        }
        private void btnMoverDerecha_Click(object sender, EventArgs e)
        {
            if (listbUnassigned.Items.Count > 0 && listbUnassigned.SelectedItem != null) 
            {
                for (int i = 0; i < listbUnassigned.Items.Count; i++)
                {
                    if (listbUnassigned.GetSelected(i)) 
                    {
                        listbAssigned.Items.Add(listbUnassigned.Items[i]);
                    }
                }
                for (int i = 0; i < listbUnassigned.Items.Count; i++)
                {
                    if (listbUnassigned.GetSelected(i))
                    {
                        listbUnassigned.Items.Remove(listbUnassigned.Items[i]);
                    }
                }
                btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Bold);
                btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void btnMoverIzquierda_Click(object sender, EventArgs e)
        {
            if (listbAssigned.Items.Count > 0 && listbAssigned.SelectedItem != null)
            {
                for (int i = 0; i < listbAssigned.Items.Count; i++)
                {
                    if (listbAssigned.GetSelected(i))
                    {
                        listbUnassigned.Items.Add(listbAssigned.Items[i]);
                    }
                }
                for (int i = 0; i < listbAssigned.Items.Count; i++)
                {
                    if (listbAssigned.GetSelected(i))
                    {
                        listbAssigned.Items.Remove(listbAssigned.Items[i]);
                    }
                }
                btnGuardarConductorxCamion.Font = new Font(btnGuardarConductorxCamion.Font.Name, btnGuardarConductorxCamion.Font.Size, FontStyle.Bold);
                btnGuardarConductorxCamion.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnGuardarConductorxCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                for (int i = 0; i < listbAssigned.Items.Count; i++)
                {
                    if (listbAssigned.GetSelected(i))
                    {
                        listbUnassigned.Items.Add(listbAssigned.Items[i]);
                    }
                }
                if (!datalayer.GuardaConductorxCamion(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtRutaAsignada.Text))
                    {
                        lblResultado.Text = datalayer._LatestError;
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;
                        datalayer._LatestError = "";
                    }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
