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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if ((string.IsNullOrEmpty(txtBuscar.Text)) || (string.IsNullOrWhiteSpace(txtBuscar.Text)))
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    CargaGrid(txtBuscar.Text);
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

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){btnBuscar_Click(this, new EventArgs());}
        }
        private void CargaGrid(string prmBuscar)
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
        private void LimpiaBoxes()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtRutaAsignada.Text = "";
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargaGrid("");
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            CargaGrid("");
        }

        private void txtCapKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCapVolumen_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosConPunto(sender, e);
        }

        private void tabMainForm_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMainForm.TabIndex == 0) { txtCedula.Select(txtCedula.Text.Length, 0); }
            //if (tabMainForm.TabIndex == tabMainForm.TabPages["tabConductores"]){ this.ActiveControl = txtCedula; }
        }

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
                        LimpiaBoxes();
                        CargaGrid("");
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

        private void btnGuardaCamion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (
                       (string.IsNullOrEmpty(txtPlaca.Text)) || (string.IsNullOrWhiteSpace(txtPlaca.Text))
                    || (string.IsNullOrEmpty(numModelo.Text)) || (string.IsNullOrWhiteSpace(numModelo.Text))
                    || (string.IsNullOrEmpty(cbMarca.SelectedText)) || (string.IsNullOrWhiteSpace(cbMarca.SelectedText))
                    || (string.IsNullOrEmpty(txtCapKilos.Text)) || (string.IsNullOrWhiteSpace(txtCapKilos.Text))
                    || (string.IsNullOrEmpty(txtCapVolumen.Text)) || (string.IsNullOrWhiteSpace(txtCapVolumen.Text))
                    )
                {
                    lblResultado.Text = "Valores en formato incorrecto o nulos";
                }
                else
                {
                    if (!datalayer.GuardaCamion(txtPlaca.Text, numModelo.Text, cbMarca.SelectedText, txtCapKilos.Text, txtCapVolumen.Text))
                    {
                        lblResultado.Text = datalayer._LatestError;
                    }
                    else
                    {
                        lblResultado.Text = datalayer._LatestError;
                        datalayer._LatestError = "";
                        LimpiaBoxes();
                        CargaGrid("");
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
    }
}
