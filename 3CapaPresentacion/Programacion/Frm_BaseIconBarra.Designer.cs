namespace _3CapaPresentacion.Programacion
{
    partial class Frm_BaseIconBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BaseIconBarra));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar_NuevoIcon = new DevExpress.XtraBars.BarButtonItem();
            this.bar_AbrirIcon = new DevExpress.XtraBars.BarButtonItem();
            this.bar_GuardarIcon = new DevExpress.XtraBars.BarButtonItem();
            this.bar_BorrarIcon = new DevExpress.XtraBars.BarButtonItem();
            this.bar_ImprimirIcon = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_NuevoIcon,
            this.bar_AbrirIcon,
            this.bar_GuardarIcon,
            this.bar_BorrarIcon,
            this.bar_ImprimirIcon});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Pressed.Options.UseFont = true;
            this.bar2.BarName = "Menú principal";
            this.bar2.CanDockStyle = ((DevExpress.XtraBars.BarCanDockStyle)(((((DevExpress.XtraBars.BarCanDockStyle.Left | DevExpress.XtraBars.BarCanDockStyle.Top) 
            | DevExpress.XtraBars.BarCanDockStyle.Right) 
            | DevExpress.XtraBars.BarCanDockStyle.Bottom) 
            | DevExpress.XtraBars.BarCanDockStyle.Standalone)));
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(58, 133);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_NuevoIcon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_AbrirIcon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_GuardarIcon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_BorrarIcon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bar_ImprimirIcon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // bar_NuevoIcon
            // 
            this.bar_NuevoIcon.Caption = "Nuevo";
            this.bar_NuevoIcon.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_NuevoIcon.Glyph")));
            this.bar_NuevoIcon.Id = 0;
            this.bar_NuevoIcon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_NuevoIcon.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_NuevoIcon.Name = "bar_NuevoIcon";
            this.bar_NuevoIcon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_NuevoIcon_ItemClick);
            // 
            // bar_AbrirIcon
            // 
            this.bar_AbrirIcon.Caption = "Abrir";
            this.bar_AbrirIcon.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_AbrirIcon.Glyph")));
            this.bar_AbrirIcon.Id = 1;
            this.bar_AbrirIcon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_AbrirIcon.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_AbrirIcon.Name = "bar_AbrirIcon";
            this.bar_AbrirIcon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_AbrirIcon_ItemClick);
            // 
            // bar_GuardarIcon
            // 
            this.bar_GuardarIcon.Caption = "Guardar";
            this.bar_GuardarIcon.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_GuardarIcon.Glyph")));
            this.bar_GuardarIcon.Id = 2;
            this.bar_GuardarIcon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_GuardarIcon.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_GuardarIcon.Name = "bar_GuardarIcon";
            this.bar_GuardarIcon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_GuardarIcon_ItemClick);
            // 
            // bar_BorrarIcon
            // 
            this.bar_BorrarIcon.Caption = "Borrar";
            this.bar_BorrarIcon.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_BorrarIcon.Glyph")));
            this.bar_BorrarIcon.Id = 3;
            this.bar_BorrarIcon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_BorrarIcon.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_BorrarIcon.Name = "bar_BorrarIcon";
            this.bar_BorrarIcon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_BorrarIcon_ItemClick);
            // 
            // bar_ImprimirIcon
            // 
            this.bar_ImprimirIcon.Caption = "Imprimir";
            this.bar_ImprimirIcon.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_ImprimirIcon.Glyph")));
            this.bar_ImprimirIcon.Id = 4;
            this.bar_ImprimirIcon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_ImprimirIcon.ItemAppearance.Normal.Options.UseFont = true;
            this.bar_ImprimirIcon.Name = "bar_ImprimirIcon";
            this.bar_ImprimirIcon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ImprimirIcon_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // Frm_BaseIconBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_BaseIconBarra";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bar_NuevoIcon;
        private DevExpress.XtraBars.BarButtonItem bar_AbrirIcon;
        private DevExpress.XtraBars.BarButtonItem bar_GuardarIcon;
        private DevExpress.XtraBars.BarButtonItem bar_BorrarIcon;
        private DevExpress.XtraBars.BarButtonItem bar_ImprimirIcon;
    }
}