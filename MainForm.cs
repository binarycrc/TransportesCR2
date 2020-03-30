using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportesCR2
{
    public partial class MainForm : Form
    {
        #region DECLARACION DE ARREGLOS
        Camion[] camions = new Camion[20]; // Arreglo de tipo Camion
        Conductor[] conductors = new Conductor[20]; // Arreglo de tipo Conductor
        #endregion DECLARACION DE ARREGLOS
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
