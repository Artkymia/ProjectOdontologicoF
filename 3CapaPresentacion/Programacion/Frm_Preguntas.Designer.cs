namespace _3CapaPresentacion.Programacion
{
    partial class Frm_Preguntas
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
            this.txt_Pregunta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pregunta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pregunta
            // 
            this.txt_Pregunta.Location = new System.Drawing.Point(184, 66);
            this.txt_Pregunta.Name = "txt_Pregunta";
            this.txt_Pregunta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pregunta.Properties.Appearance.Options.UseFont = true;
            this.txt_Pregunta.Size = new System.Drawing.Size(100, 22);
            this.txt_Pregunta.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(75, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Pregunta";
            // 
            // Frm_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 411);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Pregunta);
            this.Name = "Frm_Preguntas";
            this.Text = "Frm_Preguntas";
            this.Controls.SetChildIndex(this.txt_Pregunta, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pregunta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Pregunta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}