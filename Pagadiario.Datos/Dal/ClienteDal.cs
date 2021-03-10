using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace Pagadiario.Datos.Dal
{
    public class ClienteDal
    {
        SqlConnection conexion;
        string cadenaConexion;
        List<ClienteModel> lstClienteModel;
        int result;

        public ClienteDal()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }

        public List<ClienteModel> SeleccionarTodos()
        {
            lstClienteModel = new List<ClienteModel>();
            string query = "SELECT * FROM Cliente";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstClienteModel = conexion.Query<ClienteModel>(query).ToList();
            }

            return lstClienteModel;
        }

        public List<ClienteModel> SeleccionarTodosActivos()
        {
            lstClienteModel = new List<ClienteModel>();
            string query = "SELECT * FROM Cliente WHERE Activo = 'True' ";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstClienteModel = conexion.Query<ClienteModel>(query).ToList();
            }

            return lstClienteModel;
        }

        public List<ClienteModel> SeleccionarTodosInactivos()
        {
            lstClienteModel = new List<ClienteModel>();
            string query = "SELECT * FROM Cliente WHERE Activo = 'False' ";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstClienteModel = conexion.Query<ClienteModel>(query).ToList();
            }

            return lstClienteModel;
        }

        public int Insertar(ClienteModel clienteModel)
        {
            string query = "INSERT INTO Cliente(Cedula, Nombres, Telefono, Celular, Direccion, Notas, Activo) VALUES(@Cedula, @Nombres, @Telefono, @Celular, @Direccion, @Notas, @Activo)";
            
            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Cedula", clienteModel.Cedula);
                parametros.Add("@Nombres", clienteModel.Nombres);
                parametros.Add("@Telefono", clienteModel.Telefono);
                parametros.Add("@Celular", clienteModel.Celular);
                parametros.Add("@Direccion", clienteModel.Direccion);
                parametros.Add("@Notas", clienteModel.Notas);
                parametros.Add("@Activo", clienteModel.Activo);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

        public int Actualizar(ClienteModel clienteModel)
        {
            string query = "UPDATE Cliente SET Cedula=@Cedula, Nombres=@Nombres, Telefono=@Telefono, Celular=@Celular, Direccion=@Direccion, Notas=@Notas, Activo=@Activo WHERE ClienteId=@ClienteId;";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Cedula", clienteModel.Cedula);
                parametros.Add("@Nombres", clienteModel.Nombres);
                parametros.Add("@Telefono", clienteModel.Telefono);
                parametros.Add("@Celular", clienteModel.Celular);
                parametros.Add("@Direccion", clienteModel.Direccion);
                parametros.Add("@Notas", clienteModel.Notas);
                parametros.Add("@Activo", clienteModel.Activo);
                parametros.Add("@ClienteId", clienteModel.ClienteId);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

    }
}
