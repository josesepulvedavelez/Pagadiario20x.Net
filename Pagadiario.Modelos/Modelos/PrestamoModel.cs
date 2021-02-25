﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Modelos.Modelos
{
    public class PrestamoModel
    {
        public string No { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double Interes { get; set; }
        public string FormaPago { get; set; }
        public DateTime FechaLimite { get; set; }
        public double TotalPagar { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }        
        public int ClienteId { get; set; }  
        public int PrestamoId { get; set; }
    }
}