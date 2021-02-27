using Pagadiario.Datos.Dal;
using Pagadiario.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagadiario.Negocios.Bll
{
    public class CobradorBll
    {
        List<CobradorModel> lstCobradorModel;
        CobradorDal cobradorDal;
        int result;

        public List<CobradorModel> SeleccionarTodos()
        {
            cobradorDal = new CobradorDal();
            lstCobradorModel = cobradorDal.SeleccionarTodos();

            return lstCobradorModel;
        }

        public int Insertar(CobradorModel cobradorModel)
        {
            cobradorDal = new CobradorDal();
            result = cobradorDal.Insertar(cobradorModel);

            return result;
        }

        public int Actualizar(CobradorModel cobradorModel)
        {
            cobradorDal = new CobradorDal();
            result = cobradorDal.Actualizar(cobradorModel);

            return result;
        }
    }
}
