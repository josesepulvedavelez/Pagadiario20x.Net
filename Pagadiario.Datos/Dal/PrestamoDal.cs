using Pagadiario.Modelos.Dtos;
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
    public class PrestamoDal
    {
        SqlConnection conexion;
        string cadenaConexion;
        List<PrestamoDto> lstPrestamoModel;
        int result;

        public PrestamoDal()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }

        public List<PrestamoDto> SeleccionarTodos()
        {
            lstPrestamoModel = new List<PrestamoDto>();
            string query = "SELECT * FROM PrestamoView ORDER BY PrestamoId DESC";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstPrestamoModel = conexion.Query<PrestamoDto>(query).ToList();
            }

            return lstPrestamoModel;
        }

        public int Insertar(PrestamoModel prestamoModel)
        {
            string query = "INSERT INTO Prestamo(No, Fecha, Monto, Interes, FormaPago, FechaLimite, TotalPagar, Notas, Activo, ClienteId) VALUES(@No, @Fecha, @Monto, @Interes, @FormaPago, @FechaLimite, @TotalPagar, @Notas, @Activo, @ClienteId)";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@No", prestamoModel.No);
                parametros.Add("@Fecha", prestamoModel.Fecha);
                parametros.Add("@Monto", prestamoModel.Monto);
                parametros.Add("@Interes", prestamoModel.Interes);
                parametros.Add("@FormaPago", prestamoModel.FormaPago);
                parametros.Add("@FechaLimite", prestamoModel.FechaLimite);
                parametros.Add("@TotalPagar", prestamoModel.TotalPagar);
                parametros.Add("@Notas", prestamoModel.Notas);
                parametros.Add("@Activo", prestamoModel.Activo);
                parametros.Add("@ClienteId", prestamoModel.ClienteId);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

        public int Actualizar(PrestamoModel prestamoModel)
        {
            string query = "UPDATE Prestamo SET No=@No, Fecha=@Fecha, Monto=@Monto, Interes=@Interes, FormaPago=@FormaPago, FechaLimite=@FechaLimite, TotalPagar=@TotalPagar, Notas=@Notas, Activo=@Activo, ClienteId=@ClienteId WHERE PrestamoId=@PrestamoId";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@No", prestamoModel.No);
                parametros.Add("@Fecha", prestamoModel.Fecha);
                parametros.Add("@Monto", prestamoModel.Monto);
                parametros.Add("@Interes", prestamoModel.Interes);
                parametros.Add("@FormaPago", prestamoModel.FormaPago);
                parametros.Add("@FechaLimite", prestamoModel.FechaLimite);
                parametros.Add("@TotalPagar", prestamoModel.TotalPagar);
                parametros.Add("@Notas", prestamoModel.Notas);
                parametros.Add("@Activo", prestamoModel.Activo);
                parametros.Add("@ClienteId", prestamoModel.ClienteId);
                parametros.Add("@PrestamoId", prestamoModel.PrestamoId);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

    }
}
