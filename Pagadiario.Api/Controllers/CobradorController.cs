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
    [RoutePrefix("Api/Cobrador")]
    public class CobradorController : ApiController
    {
        CobradorBll cobradorBll;

        [HttpGet]
        [Route("SeleccionarTodos")]
        public List<CobradorModel> SeleccionarTodos()
        {
            cobradorBll = new CobradorBll();
            return cobradorBll.SeleccionarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public int Insertar(CobradorModel cobradorModel)
        {
            cobradorBll = new CobradorBll();
            return cobradorBll.Insertar(cobradorModel);
        }

        [HttpPut]
        [Route("Actualizar")]
        public int Actualizar(CobradorModel cobradorModel)
        {
            cobradorBll = new CobradorBll();
            return cobradorBll.Actualizar(cobradorModel);
        }

    }
}
