using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using _2CapaNegocio;
namespace _3CapaPresentacion.Pacientes
{
  
    public partial class Frm_Paciente : Programacion.Frm_BaseIconBarra
    {

        _2CapaNegocio.CapaPacientes negocio = new _2CapaNegocio.CapaPacientes();
        public Frm_Paciente()
        {
            InitializeComponent();
        }

        private void Frm_Paciente_Load(object sender, EventArgs e)
        {
            negocio.ConsultaGeneralOracle("*", "Pacientes", "", "");
            dateNac.EditValue = DateTime.Now;
        }

        private void btn_BuscarImagen_Click(object sender, EventArgs e)
        {
            PicImagen.LoadImage();
        }

        private void btn_QuitarImagen_Click(object sender, EventArgs e)
        {
            PicImagen.Image = null;
        }
        //Acciones para el boton de Nuevo
        protected override void NuevoButton()
        {
            base.NuevoButton();
            PicImagen.Image = null;
            txt_Apellidos.Text = "";
            txt_Nombres.Text = "";
            txt_Cedula.Text = "";
            txt_Direccion.Text = "";
        }
        //Fin de acciones para el boton Nuevo
        //Acciones para el boton de Guardar
        protected override string ComprobarInsertar()
        {
            String Errores = "Se encontraron los siguientes errores: \n";
            Int32 Cont = 0;
            if ( txt_Cedula.Text.Trim() == "")
            {
                Cont += 1;
                Errores += "-Cedula esta vacio \n";
            }

            if (txt_Apellidos.Text.Trim() == "")
            {
                Cont += 1;
                Errores += "-Apellidos esta vacio \n";
            }

            if (txt_Nombres.Text.Trim() == "")
            {
                Cont += 1;
                Errores += "-Nombres esta vacio \n";
            }
            if (txt_Direccion.Text.Trim() == "")
            {
                Cont += 1;
                Errores += "-Direccion esta vacio \n";
            }

            if (Cont != 0)
            {
                return Errores;
            }
            return base.ComprobarInsertar();
        }
        protected override void Insertar()
        {
         Int32 id = Convert.ToInt32(  negocio.Frm_PacienteInsert(txt_Cedula.Text.Trim(), txt_Apellidos.Text.Trim(), txt_Nombres.Text.Trim(), txt_Direccion.Text.Trim(), FechaVb_FechaAccess( Convert.ToDateTime( dateNac.EditValue), "dd/MM/yyyy","dd/MM/yyyy")));
         Mensage(id.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Fin de Acciones para el boton de Guardar

    }
}