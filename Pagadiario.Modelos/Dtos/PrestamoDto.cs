using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Modelos.Dtos
{
    public class PrestamoDto
    {
        public string CcCliente { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public int PrestamoId { get; set; }
        public string No { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaLimite { get; set; }
        public int Tiempo { get; set; }
        public double Monto { get; set; }
        public double Interes { get; set; }
        public string FormaPago { get; set; }
        public double Cuota { get; set; }
        public double TotalPagar { get; set; }
        public double TotalPagos { get; set; }
        public double Saldo { get; set; }
        public bool Activo { get; set; }
    }
}
