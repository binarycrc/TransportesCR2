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
    class Vehiculo
    {
        /// <summary>
        /// Clase base para registro para tipos de empleados
        /// </summary>
        string _placa;
        int _modelo;
        /// <summary>
        /// Constructor de la clase Vehiculo
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="modelo"></param>
        public Vehiculo(string placa, int modelo)
        {
            _placa = placa;
            _modelo = modelo;
        }
        /// <summary>
        /// Propiedad para el campo placa
        /// </summary>
        public string Placa { get { return _placa; } set { _placa = value; } }
        /// <summary>
        /// Propiedad para el campo Modelo
        /// </summary>
        public int Modelo { get { return _modelo; } set { _modelo = value; } }
    }
}
