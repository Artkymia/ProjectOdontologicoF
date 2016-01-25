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
            this.txt_Apellidos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Cedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nombres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Direccion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateNac = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Apellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Direccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNac.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNac.Properties)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(195, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Apellidos:";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Apellidos.Location = new System.Drawing.Point(257, 81);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Properties.Appearance.Options.UseFont = true;
            this.txt_Apellidos.Properties.MaxLength = 50;
            this.txt_Apellidos.Size = new System.Drawing.Size(496, 22);
            this.txt_Apellidos.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(195, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Cedula:";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cedula.Location = new System.Drawing.Point(257, 53);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Properties.Appearance.Options.UseFont = true;
            this.txt_Cedula.Properties.Mask.EditMask = "\\d+";
            this.txt_Cedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Cedula.Properties.MaxLength = 13;
            this.txt_Cedula.Size = new System.Drawing.Size(223, 22);
            this.txt_Cedula.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(195, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nombres:";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombres.Location = new System.Drawing.Point(257, 109);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.Properties.Appearance.Options.UseFont = true;
            this.txt_Nombres.Properties.MaxLength = 50;
            this.txt_Nombres.Size = new System.Drawing.Size(496, 22);
            this.txt_Nombres.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(195, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Direccion:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Direccion.Location = new System.Drawing.Point(257, 135);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Properties.Appearance.Options.UseFont = true;
            this.txt_Direccion.Properties.MaxLength = 100;
            this.txt_Direccion.Size = new System.Drawing.Size(496, 22);
            this.txt_Direccion.TabIndex = 3;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(257, 163);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Mask.EditMask = "\\d+";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit1.Properties.MaxLength = 13;
            this.textEdit1.Size = new System.Drawing.Size(223, 22);
            this.textEdit1.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(195, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Telefono:";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(486, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 16);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "F. Nacimiento:";
            // 
            // dateNac
            // 
            this.dateNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNac.EditValue = null;
            this.dateNac.Location = new System.Drawing.Point(575, 53);
            this.dateNac.Name = "dateNac";
            this.dateNac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNac.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNac.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNac.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNac.Size = new System.Drawing.Size(178, 20);
            this.dateNac.TabIndex = 16;
            // 
            // Frm_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 499);
            this.Controls.Add(this.dateNac);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_Apellidos);
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
            this.Controls.SetChildIndex(this.txt_Apellidos, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txt_Cedula, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txt_Nombres, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txt_Direccion, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.dateNac, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Apellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Direccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNac.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNac.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PictureEdit PicImagen;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarImagen;
        private DevExpress.XtraEditors.SimpleButton btn_QuitarImagen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Apellidos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Cedula;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Nombres;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Direccion;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateNac;
    }
}