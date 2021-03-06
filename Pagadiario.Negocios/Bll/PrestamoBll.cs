﻿using Pagadiario.Datos.Dal;
using Pagadiario.Modelos.Dtos;
using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Negocios.Bll
{
    public class PrestamoBll
    {
        List<PrestamoDto> lstPrestamoModel;
        PrestamoDal prestamoDal;
        int result;

        public List<PrestamoDto> SeleccionarTodos()
        {
            prestamoDal = new PrestamoDal();
            lstPrestamoModel = prestamoDal.SeleccionarTodos();

            return lstPrestamoModel;
        }

        public List<PrestamoDto> SeleccionarTodosActivos()
        {
            prestamoDal = new PrestamoDal();
            lstPrestamoModel = prestamoDal.SeleccionarTodosActivos();

            return lstPrestamoModel;
        }

        public List<PrestamoDto> SeleccionarTodoInactivos()
        {
            prestamoDal = new PrestamoDal();
            lstPrestamoModel = prestamoDal.SeleccionarTodosInactivos();

            return lstPrestamoModel;
        }

        public int Insertar(PrestamoModel prestamoModel)
        {
            prestamoDal = new PrestamoDal();
            result = prestamoDal.Insertar(prestamoModel);

            return result;
        }

        public int Actualizar(PrestamoModel prestamoModel)
        {
            prestamoDal = new PrestamoDal();
            result = prestamoDal.Actualizar(prestamoModel);

            return result;
        }

    }
}
