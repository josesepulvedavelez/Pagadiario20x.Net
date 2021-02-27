using Pagadiario.Datos.Dal;
using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Negocios.Bll
{
    public class ClienteBll
    {
        List<ClienteModel> lstClienteModel;
        ClienteDal clienteDal;
        int result;

        public List<ClienteModel> SeleccionarTodos()
        {
            clienteDal = new ClienteDal();
            lstClienteModel = clienteDal.SeleccionarTodos();

            return lstClienteModel;
        }

        public int Insertar(ClienteModel clienteModel)
        {
            clienteDal = new ClienteDal();
            result = clienteDal.Insertar(clienteModel);

            return result;
        }

        public int Actualizar(ClienteModel clienteModel)
        {
            clienteDal = new ClienteDal();
            result = clienteDal.Actualizar(clienteModel);

            return result;
        }

    }
}
