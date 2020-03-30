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
    class Conductor : Empleado
    {
        /// <summary>
        /// Clase para el tipo de Empleado, Conductor
        /// </summary>
        int _ruta;
        /// <summary>
        /// Constructor de la clase Conductor con herencia de Empleado
        /// </summary>
        /// <param name="identificacion"></param>
        /// <param name="papellido"></param>
        /// <param name="sapellido"></param>
        public Conductor(string identificacion, string papellido, string sapellido)
            : base(identificacion, papellido, sapellido)
        {
        }
        /// <summary>
        /// Propiedad del campo ruta
        /// </summary>
        public int ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }
    }
}
