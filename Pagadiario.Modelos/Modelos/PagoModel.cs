﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Modelos.Modelos
{
    public class PagoModel
    {
        public DateTime Fecha { get; set; }
        public double Pago { get; set; }
        public DateTime ProximoPago { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }
        public int PrestamoId { get; set; }
        public int CobradorId { get; set; }        
        public int PagoId { get; set; }
    }
}
