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
    [RoutePrefix("Api/Prestamo")]
    public class PrestamoController : ApiController
    {
        PrestamoBll prestamoBll;

        [HttpGet]
        [Route("SeleccionarTodos")]
        public List<PrestamoDto> SeleccionarTodos()
        {
            prestamoBll = new PrestamoBll();
            return prestamoBll.SeleccionarTodos();
        }

        [HttpGet]
        [Route("SeleccionarTodosActivos")]
        public List<PrestamoDto> SeleccionarTodosActivos()
        {
            prestamoBll = new PrestamoBll();
            return prestamoBll.SeleccionarTodosActivos();
        }

        [HttpGet]
        [Route("SeleccionarTodosInactivos")]
        public List<PrestamoDto> SeleccionarTodosInactivos()
        {
            prestamoBll = new PrestamoBll();
            return prestamoBll.SeleccionarTodoInactivos();
        }

        [HttpPost]
        [Route("Insertar")]
        public int Insertar(PrestamoModel prestamoModel)
        {
            prestamoBll = new PrestamoBll();
            return prestamoBll.Insertar(prestamoModel);
        }
         
        [HttpPut]
        [Route("Actualizar")]
        public int Actualizar(PrestamoModel prestamoModel)
        {
            prestamoBll = new PrestamoBll();
            return prestamoBll.Actualizar(prestamoModel);
        }

    }
}
