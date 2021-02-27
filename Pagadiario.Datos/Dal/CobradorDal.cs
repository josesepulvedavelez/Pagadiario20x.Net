using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Pagadiario.Datos.Dal
{
    public class CobradorDal
    {
        SqlConnection conexion;
        string cadenaConexion;
        List<CobradorModel> lstCobradorModel;
        int result;

        public CobradorDal()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }

        public List<CobradorModel> SeleccionarTodos()
        {
            lstCobradorModel = new List<CobradorModel>();
            string query = "SELECT * FROM Cobrador";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstCobradorModel = conexion.Query<CobradorModel>(query).ToList();
            }

            return lstCobradorModel;
        }

        public int Insertar(CobradorModel cobradorModel)
        {
            string query = "INSERT INTO Cobrador(Cedula, Nombres, Telefono, Celular, Direccion, Notas, Activo) VALUES(@Cedula, @Nombres, @Telefono, @Celular, @Direccion, @Notas, @Activo)";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Cedula", cobradorModel.Cedula);
                parametros.Add("@Nombres", cobradorModel.Nombres);
                parametros.Add("@Telefono", cobradorModel.Telefono);
                parametros.Add("@Celular", cobradorModel.Celular);
                parametros.Add("@Direccion", cobradorModel.Direccion);
                parametros.Add("@Notas", cobradorModel.Notas);
                parametros.Add("@Activo", cobradorModel.Activo);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

        public int Actualizar(CobradorModel cobradorModel)
        {
            string query = "UPDATE Cobrador SET Cedula=@Cedula, Nombres=@Nombres, Telefono=@Telefono, Celular=@Celular, Direccion=@Direccion, Notas=@Notas, Activo=@Activo WHERE CobradorId=@CobradorId;";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Cedula", cobradorModel.Cedula);
                parametros.Add("@Nombres", cobradorModel.Nombres);
                parametros.Add("@Telefono", cobradorModel.Telefono);
                parametros.Add("@Celular", cobradorModel.Celular);
                parametros.Add("@Direccion", cobradorModel.Direccion);
                parametros.Add("@Notas", cobradorModel.Notas);
                parametros.Add("@Activo", cobradorModel.Activo);
                parametros.Add("@CobradorId", cobradorModel.CobradorId);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }
    }
}
