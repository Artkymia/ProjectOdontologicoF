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
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.PicImagen = new DevExpress.XtraEditors.PictureEdit();
            this.btn_BuscarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QuitarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "$_12.jpg");
            // 
            // PicImagen
            // 
            this.PicImagen.Location = new System.Drawing.Point(12, 46);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PicImagen.Size = new System.Drawing.Size(173, 160);
            this.PicImagen.TabIndex = 0;
            // 
            // btn_BuscarImagen
            // 
            this.btn_BuscarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarImagen.Image")));
            this.btn_BuscarImagen.Location = new System.Drawing.Point(12, 211);
            this.btn_BuscarImagen.Name = "btn_BuscarImagen";
            this.btn_BuscarImagen.Size = new System.Drawing.Size(173, 23);
            this.btn_BuscarImagen.TabIndex = 4;
            this.btn_BuscarImagen.Text = "Buscar Imagen";
            this.btn_BuscarImagen.Click += new System.EventHandler(this.btn_BuscarImagen_Click);
            // 
            // btn_QuitarImagen
            // 
            this.btn_QuitarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuitarImagen.Image")));
            this.btn_QuitarImagen.Location = new System.Drawing.Point(12, 239);
            this.btn_QuitarImagen.Name = "btn_QuitarImagen";
            this.btn_QuitarImagen.Size = new System.Drawing.Size(173, 23);
            this.btn_QuitarImagen.TabIndex = 5;
            this.btn_QuitarImagen.Text = "Quitar Imagen";
            this.btn_QuitarImagen.Click += new System.EventHandler(this.btn_QuitarImagen_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(191, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nombre:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(247, 55);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 22);
            this.textEdit1.TabIndex = 7;
            // 
            // Frm_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 499);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_QuitarImagen);
            this.Controls.Add(this.btn_BuscarImagen);
            this.Controls.Add(this.PicImagen);
            this.Name = "Frm_Paciente";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Frm_Paciente_Load);
            this.Controls.SetChildIndex(this.PicImagen, 0);
            this.Controls.SetChildIndex(this.btn_BuscarImagen, 0);
            this.Controls.SetChildIndex(this.btn_QuitarImagen, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PictureEdit PicImagen;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarImagen;
        private DevExpress.XtraEditors.SimpleButton btn_QuitarImagen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}