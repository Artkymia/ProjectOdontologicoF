using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace _1CapaDatos
{
    public class BaseDatos
    {
        public string cadenaConexion
        {
            get { return Convert.ToString(ConfigurationManager.ConnectionStrings["Conect"]); }
        }


        public string myProvider
        {

            get { return Convert.ToString(ConfigurationManager.AppSettings.Get("Provider")); }
        }

        public DbProviderFactory dpf
        {
            get { return DbProviderFactories.GetFactory(myProvider); }
        }

        private DbConnection conexion = null;
        private DbCommand comando = null;
        private DbTransaction transaccion = null;

        private DbCommandBuilder builder = null;

        public void conectar()
        {
            if (this.conexion != null && !this.conexion.State.Equals(ConnectionState.Closed))
            {
                throw new Exception("La conexión ya se encuentra abierta");
                // Using (comando = dpf.CreateCommand())

                //End Using
            }
            try
            {
                if (this.conexion == null)
                {
                    this.conexion = dpf.CreateConnection();
                    this.conexion.ConnectionString = cadenaConexion;
                }
                this.conexion.Open();

            }
            catch (DataException ex)
            {
                throw new Exception("Error al conectarse con la base de datos", ex);

            }

        }

        public void desconectar()
        {
            if (this.conexion.State.Equals(ConnectionState.Open))
            {
                this.conexion.Close();
            }
        }


        public void previo(string strSql, params object[] parametros)
        {
            bool error1 = false;

            this.comando = dpf.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.StoredProcedure;
            this.comando.CommandText = strSql;
            if (this.transaccion != null)
            {
                this.comando.Transaction = this.transaccion;

            }

            builder = dpf.CreateCommandBuilder();
            Type tipocomando = this.builder.GetType();
            MethodInfo info = tipocomando.GetMethod("DeriveParameters");

            if (info != null)
            {
                try
                {
                    info.Invoke(null, new object[] { this.comando });
                }
                catch (Exception ex)
                {
                    System.Console.Write(ex);
                    error1 = true;
                }
            }
            else
            {
                error1 = true;
            }

            //builder.DeriveParameters(Me.comando)
            if (!error1)
            {
                if (parametros.Length > 0)
                {
                    int contador = 0;
                    foreach (object item in parametros)
                    {
                        comando.Parameters[contador].Value = item;
                        contador += 1;
                    }
                }
            }
        }

        public void previo(string strSql)
        {
            this.comando = dpf.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = strSql;
            if (this.transaccion != null)
            {
                this.comando.Transaction = this.transaccion;
            }
        }

        public void ejecutar(string strSql)
        {
            previo(strSql);
            this.comando.ExecuteNonQuery();
        }
        public object ejecutarEscalar(string strsql)
        {
            previo(strsql);
            return this.comando.ExecuteScalar();
        }

        public DataTable ejecutarDataTable(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            DataSet ds = new DataSet();
            //    'Dim NpgsqlDataAdapter(Me.comando).Fill(ds) as New 
            DbDataAdapter Adapter = dpf.CreateDataAdapter();
            Adapter.SelectCommand = this.comando;
            Adapter.Fill(ds);
            return ds.Tables[0].Copy();
        }

        public DataTable ejecutarDataTable(string strSql)
        {
            previo(strSql);
            DataSet ds = new DataSet();
            DbDataAdapter Adapter = dpf.CreateDataAdapter();
            Adapter.SelectCommand = this.comando;
            Adapter.Fill(ds);
            //Dim reader As NpgsqlDataReader = Me.comando.ExecuteReader()
            //Dim ds As New DataTable()
            //ds.Load(reader)
            return ds.Tables[0].Copy();

        }

        public DbDataReader ejecutarReader(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            return this.comando.ExecuteReader();

        }

        public object ejecutarEscalar(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            return this.comando.ExecuteScalar();
        }

        public void ejecutar(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            this.comando.ExecuteNonQuery();

        }

        public void comenzarTransaccion()
        {
            if (this.transaccion == null)
            {
                this.transaccion = this.conexion.BeginTransaction();
            }
        }

        public void cancelarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Rollback();
            }
        }

        public void confirmarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Commit();
            }
        }
    }
}
