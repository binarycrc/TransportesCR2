/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportesCR2
{
    class Camion : Vehiculo
    {
        /// <summary>
        /// Clase para el tipo de Vehiculo, Camion
        /// </summary>
        int _capacidadkilos;
        int _capacidadvolumen;
        /// <summary>
        /// Constructor de la clase Camion con herencia de Vehiculo
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="modelo"></param>
        public Camion(string placa, int modelo)
            : base(placa, modelo)
        {
        }
        /// <summary>
        /// Propiedad del campo capacidad de kilos 
        /// </summary>
        public int capacidadkilos
        {
            get { return _capacidadkilos; }
            set { _capacidadkilos = value; }
        }
        /// <summary>
        /// Propiedad del campo capacidad de volumen
        /// </summary>
        public int capacidadvolumen
        {
            get { return _capacidadvolumen; }
            set { _capacidadvolumen = value; }
        }
    }
}
