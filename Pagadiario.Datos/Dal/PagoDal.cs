using Pagadiario.Modelos.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Pagadiario.Modelos.Modelos;
using System.Data;
using System.Transactions;

namespace Pagadiario.Datos.Dal
{
    public class PagoDal
    {
        SqlConnection conexion;
        string cadenaConexion;
        List<PagoDto> lstPagoModel;
        int result;

        public PagoDal()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }

        public List<PagoDto> SeleccionarTodos() 
        {
            lstPagoModel = new List<PagoDto>();
            string query = "SELECT * FROM PagosView";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                lstPagoModel = conexion.Query<PagoDto>(query).ToList();
            }

            return lstPagoModel;
        }

        public int Insertar(PagoModel pagoModel)
        {
            string query = "INSERT INTO Pagos(Fecha, Pago, ProximoPago, Notas, Activo, PrestamoId, CobradorId) VALUES(@Fecha, @Pago, @ProximoPago, @Notas, @Activo, @PrestamoId, @CobradorId)";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Fecha", pagoModel.Fecha);
                parametros.Add("@Pago", pagoModel.Pago);
                parametros.Add("@ProximoPago", pagoModel.ProximoPago);
                parametros.Add("@Notas", pagoModel.Notas);
                parametros.Add("@Activo", pagoModel.Activo);
                parametros.Add("@PrestamoId", pagoModel.PrestamoId);
                parametros.Add("@CobradorId", pagoModel.CobradorId);
                
                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }

        public int Actualizar(PagoModel pagoModel)
        {
            string query = "UPDATE Pagos SET Fecha=@Fecha, Pago=@Pago, ProximoPago=@ProximoPago, Notas=@Notas, Activo=@Activo, PrestamoId=@PrestamoId, CobradorId=@CobradorId WHERE PagoId=@PagoId";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Fecha", pagoModel.Fecha);
                parametros.Add("@Pago", pagoModel.Pago);
                parametros.Add("@ProximoPago", pagoModel.ProximoPago);
                parametros.Add("@Notas", pagoModel.Notas);
                parametros.Add("@Activo", pagoModel.Activo);
                parametros.Add("@PrestamoId", pagoModel.PrestamoId);
                parametros.Add("@CobradorId", pagoModel.CobradorId);
                parametros.Add("@PagoId", pagoModel.PagoId);

                conexion.Open();
                result = conexion.Execute(query, parametros, commandType: CommandType.Text);
                conexion.Close();
            }

            return result;
        }
    }
}
