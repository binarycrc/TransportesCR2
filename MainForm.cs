using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportesCR2
{
    public partial class MainForm : Form
    {
        DataLayer dataLayer = new DataLayer();

        #region DECLARACION DE ARREGLOS
        Camion[] camions = new Camion[20]; // Arreglo de tipo Camion
        Conductor[] conductors = new Conductor[20]; // Arreglo de tipo Conductor
        #endregion DECLARACION DE ARREGLOS
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
