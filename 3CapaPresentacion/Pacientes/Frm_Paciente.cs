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
        _2CapaNegocio.CapaGeneral negocio = new _2CapaNegocio.CapaGeneral();
        public Frm_Paciente()
        {
            InitializeComponent();
        }

        private void Frm_Paciente_Load(object sender, EventArgs e)
        {
            negocio.ConsultaGeneralOracle("*", "Pacientes", "", "");
        }

        private void btn_BuscarImagen_Click(object sender, EventArgs e)
        {
            PicImagen.LoadImage();
        }

        private void btn_QuitarImagen_Click(object sender, EventArgs e)
        {
            PicImagen.Image = null;
        }
    }
}