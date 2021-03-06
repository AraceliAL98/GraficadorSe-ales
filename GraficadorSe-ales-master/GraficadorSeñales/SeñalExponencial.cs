﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalExponencial2 : Señal

    {
        public double Alpha { get; set; }

        public SeñalExponencial2(double alpha)
        {
            Alpha = alpha;

            Muestras = new List<Muestra>();
        }

        override public double evaluar(double tiempo)
        {
            double resultado;
            resultado = Math.Exp(Alpha* tiempo);
            return resultado;
            
        }
    }

    

    
}
