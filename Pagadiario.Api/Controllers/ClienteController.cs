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
    [RoutePrefix("Api/Cliente")]
    public class ClienteController : ApiController
    {
        ClienteBll clienteBll;

        [HttpGet]
        [Route("SeleccionarTodos")]
        public List<ClienteModel> SeleccionarTodos()
        {
            clienteBll = new ClienteBll();
            return clienteBll.SeleccionarTodos();
        }

        [HttpGet]
        [Route("SeleccionarTodosActivos")]
        public List<ClienteModel> SeleccionarTodosActivos()
        {
            clienteBll = new ClienteBll();
            return clienteBll.SeleccionarTodosActivos();
        }

        [HttpGet]
        [Route("SeleccionarTodosInactivos")]
        public List<ClienteModel> SeleccionarTodosInactivos()
        {
            clienteBll = new ClienteBll();
            return clienteBll.SeleccionarTodosInactivos();
        }

        [HttpPost]
        [Route("Insertar")]
        public int Insertar([FromBody] ClienteModel clienteModel)
        {
            clienteBll = new ClienteBll();
            return clienteBll.Insertar(clienteModel);
        }

        [HttpPut]
        [Route("Actualizar")]
        public int Actualizar(ClienteModel clienteModel)
        {
            clienteBll = new ClienteBll();
            return clienteBll.Actualizar(clienteModel);
        }

    }
}
