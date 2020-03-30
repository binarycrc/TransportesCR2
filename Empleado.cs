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
    class Empleado
    {
        /// <summary> 3
        /// Clase base para registro para tipos de empleados
        /// </summary>
        string _identificacion;
        string _papellido;
        string _sapellido;
        /// <summary>
        /// Constructor de la clase Empleado
        /// </summary>
        /// <param name="identificacion"></param>
        /// <param name="papellido"></param>
        /// <param name="sapellido"></param>
        public Empleado(string identificacion, string papellido, string sapellido)
        {
            _identificacion = identificacion;
            _papellido = papellido;
            _sapellido = sapellido;
        }
        /// <summary>
        /// Propiedad para el campo identificacon
        /// </summary>
        public string Identificacion { get { return _identificacion; } set { _identificacion = value; } }
        /// <summary>
        /// Propiedad para el cambpo primer apellido
        /// </summary>
        public string PApellido { get { return _papellido; } set { _papellido = value; } }
        /// <summary>
        /// Propiedad para el campo segundo apellido
        /// </summary>
        public string SApellido { get { return _sapellido; } set { _sapellido = value; } }
    }
}
