using Pagadiario.Datos.Dal;
using Pagadiario.Modelos.Dtos;
using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Negocios.Bll
{
    public class PagoBll
    {
        List<PagoDto> lstPagoModel;
        PagoDal pagoDal;
        int result;

        public List<PagoDto> SeleccionarTodos()
        {
            pagoDal = new PagoDal();
            lstPagoModel = pagoDal.SeleccionarTodos();

            return lstPagoModel;
        }

        public int Insertar(PagoModel pagoModel)
        {
            pagoDal = new PagoDal();
            result = pagoDal.Insertar(pagoModel);

            return result;
        }

        public int Actualizar(PagoModel pagoModel)
        {
            pagoDal = new PagoDal();
            result = pagoDal.Actualizar(pagoModel);

            return result;
        }

    }
}
