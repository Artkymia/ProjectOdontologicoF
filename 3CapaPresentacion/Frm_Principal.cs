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

namespace _3CapaPresentacion
{
    public partial class Frm_Principal : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Pacientes.Frm_Paciente form  = new Pacientes.Frm_Paciente();
            form.ControlBox = true;
            form.MdiParent = this;
            form.Show();
        }
    }
}