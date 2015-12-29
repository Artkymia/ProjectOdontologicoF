using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1CapaDatos;
using System.Data;

namespace _2CapaNegocio
{
    public class CapaGeneral
    {

        protected _1CapaDatos.BaseDatos BaseDatosOracle = new  _1CapaDatos.BaseDatos();
        public DataTable ConsultaGeneralOracle(string Campos, string Vista_Tabla, string Consulta, string Orden)
        {
            BaseDatosOracle = new _1CapaDatos.BaseDatos();
            DataTable tabla = new DataTable();
            try
            {
                BaseDatosOracle.conectar();
                BaseDatosOracle.comenzarTransaccion();
                tabla = BaseDatosOracle.ejecutarDataTable("select " + Campos + " from " + Vista_Tabla + " " + Consulta + " " + Orden + "");
                BaseDatosOracle.confirmarTransaccion();
                return tabla;
            }
            catch (Exception ex)
            {
                BaseDatosOracle.cancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally
            {
                BaseDatosOracle.desconectar();
            }
        }
    }
}
