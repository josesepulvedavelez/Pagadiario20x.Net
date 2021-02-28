using Pagadiario.Modelos.Dtos;
using Pagadiario.Modelos.Modelos;
using Pagadiario.Negocios.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pagadiario.Api.Controllers
{
    [RoutePrefix("Api/Pago")]
    public class PagoController : ApiController
    {
        PagoBll pagoBll;

        [HttpGet]
        [Route("SeleccionarTodos")]
        public List<PagoDto> SeleccionarTodos()
        {
            pagoBll = new PagoBll();
            return pagoBll.SeleccionarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public int Insertar(PagoModel pagoModel)
        {
            pagoBll = new PagoBll();
            return pagoBll.Insertar(pagoModel);
        }

        [HttpPut]
        [Route("Actualizar")]
        public int Actualizar(PagoModel pagoModel)
        {
            pagoBll = new PagoBll();
            return pagoBll.Actualizar(pagoModel);
        }

    }
}
