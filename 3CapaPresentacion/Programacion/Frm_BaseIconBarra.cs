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

namespace _3CapaPresentacion.Programacion
{
    public partial class Frm_BaseIconBarra : Frm_Base
    {
        public Frm_BaseIconBarra()
        {
            InitializeComponent();
        }

        private void bar_NuevoIcon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo_Click();
        }

        private void bar_AbrirIcon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Abrir_Click();
        }

        private void bar_GuardarIcon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar_Click();
        }

        private void bar_BorrarIcon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Borrar_Click();
        }

        private void bar_ImprimirIcon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Imprimir_Click();
        }
    }
}