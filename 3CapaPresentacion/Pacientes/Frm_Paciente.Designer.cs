namespace _3CapaPresentacion.Pacientes
{
    partial class Frm_Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Paciente));
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(431, 76);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.checkEdit1.Properties.HtmlImages = this.imageCollection1;
            this.checkEdit1.Properties.ImageIndexChecked = 0;
            this.checkEdit1.Properties.Images = this.imageCollection1;
            this.checkEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkEdit1.Properties.PictureChecked = ((System.Drawing.Image)(resources.GetObject("checkEdit1.Properties.PictureChecked")));
            this.checkEdit1.Properties.PictureUnchecked = ((System.Drawing.Image)(resources.GetObject("checkEdit1.Properties.PictureUnchecked")));
            this.checkEdit1.Size = new System.Drawing.Size(36, 36);
            this.checkEdit1.TabIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "$_12.jpg");
            // 
            // Frm_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 499);
            this.Controls.Add(this.checkEdit1);
            this.Name = "Frm_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Frm_Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}