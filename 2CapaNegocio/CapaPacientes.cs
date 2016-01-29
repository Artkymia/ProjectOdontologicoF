using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CapaNegocio
{
    public class CapaPacientes : CapaGeneral
    {
        protected _1CapaDatos.BaseDatos BaseDatosOracle = new _1CapaDatos.BaseDatos();

        //Funciones para Frm_Paciente
        public object Frm_PacienteInsert(string Cedula, string apellidos, string nombres, string direccion, string FechaNac)
        {
            BaseDatosOracle = new _1CapaDatos.BaseDatos();
            object id;
            try
            {
                BaseDatosOracle.conectar();
                BaseDatosOracle.comenzarTransaccion();
                 BaseDatosOracle.ejecutar("insert into Pacientes(cedula, apellidos, nombres, direccion, fecha_nac) values('" + Cedula + "', '" + apellidos + "', '" + nombres + "', '" + direccion + "', " +  FechaNac + ")");
                id = BaseDatosOracle.ejecutarEscalar(" SELECT @@IDENTITY");
                BaseDatosOracle.confirmarTransaccion();
                return id;
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
        // Fin de Funciones para Frm_Paciente
    }
}
