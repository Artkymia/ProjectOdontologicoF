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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using _2CapaNegocio;

namespace _3CapaPresentacion.Programacion
{
    public partial class Frm_Base : DevExpress.XtraEditors.XtraForm
    {
        //Variables de Formulario Base
        //'Indica que accion estoy realizando con el formulario NUEVO=INSERTAR_REGISTROS MODIFICA=ACTUALIZAR_REGISTROS
        protected string VarIndicador = "NUEVO";
        protected bool boolNuevo;
        protected bool boolAbrir;
        protected bool boolGuardar;
        protected bool boolEliminar;
        protected bool boolImprimir;
        protected bool boolProteger;
        //'4 variables y una lista para implementar busqueda con un solo formulario(aun pendiente en DevExpress)
        protected string Seleccion = "";
        protected string Vista = "";
        protected string Consulta = "";
        protected string OrdenCampo = "";
        protected string ColumnasInvisibles = "";
        //Protected CamposMostrar As List(Of String) = New List(Of String)
        protected DataTable DataBusqueda;
        protected bool EsconImagen;
        protected string ColumnaImagenr;
        protected string CategoriaImagenr;
        protected string CarpetaImagenr;
        protected string CaptionsBusqueda;
        protected int posicionImagenr = -1;
        //-----------------------------------------------------------
        //'Listas para habilitar y deshabilitar controles necesarios
        protected List<string> CamposHabilitadosDefecto = new List<string>();
        protected List<string> CamposDeshabilitadosDefecto = new List<string>();
        //-----------------------------------------------------------------------
        //--------------------------------------------------------------------

        static Frm_Base()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }
        public Frm_Base()
        {
            InitializeComponent();
        }

        //Metodos que pueden ser heredados
        protected virtual void Insertar()
        {
        }
        protected virtual void Cargar()
        {
            VarIndicador = "MODIFICA";
        }
        protected virtual void Modificar()
        {
        }
        protected virtual void Eliminar()
        {
            VarIndicador = "NUEVO";
        }
        protected virtual void NuevoButton()
        {
            VarIndicador = "NUEVO";
        }
        protected virtual void ProtegerTransaccion()
        {
        }
        protected virtual void Habilitar()
        {
        }
        protected virtual void DesHabilitar()
        {
        }
        protected virtual void ImprimirReporte()
        {
        }
        protected virtual string ComprobarInsertar()
        {
            return "SIN ERRORES";
        }
        protected virtual string ComprobarEliminar()
        {
            return "SIN ERRORES";
        }
        protected virtual string ComprobarImprimir()
        {
            return "SIN ERRORES";
        }
        protected virtual string ComprobarProcesar()
        {
            return "SIN ERRORES";
        }
        //-----------------------------------------------------------------------------

        protected virtual void Nuevo_Click()
        {
            try
            {
                VarIndicador = "NUEVO";
                NuevoButton();
                Habilitar();
            }
            catch (Exception ex)
            {
                //MsgBox("Error de Programa: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected virtual void Abrir_Click()
        {
        //    try
        //    {
        //        Frm_Busqueda Busqueda = default(Frm_Busqueda);
        //        CapaNegocio.ScriptGeneral Negocio = new CapaNegocio.ScriptGeneral();
        //        DataBusqueda = Negocio.ConsultaGeneralOracle(Seleccion, Vista, Consulta, OrdenCampo);
        //        if (EsconImagen == true)
        //        {
        //            Busqueda = new Frm_Busqueda(DataBusqueda, ColumnaImagenr, CategoriaImagenr, CarpetaImagenr, posicionImagenr, CaptionsBusqueda, ColumnasInvisibles);

        //        }
        //        else
        //        {
        //            Busqueda = new Frm_Busqueda(DataBusqueda, CaptionsBusqueda, ColumnasInvisibles);
        //        }
        //        Busqueda.ShowDialog();
        //        if ((CodigoBusqueda != "0"))
        //        {
        //            Habilitar();
        //            Cargar();
        //            VarIndicador = "MODIFICA";
        //        }
        //        //Dim Busqueda As New FrmBusqueda(Seleccion, Vista, Consulta, OrdenCampo, CamposMostrar)
        //        //Busqueda.ShowDialog()
        //        //If (Cod_Busq <> "0") Then
        //        //    VarIndicador = "MODIFICA"
        //        //    Habilitar()
        //        //    Cargar()
        //        //End If
        //    }
        //    catch (Exception ex)
        //    {
        //        DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        }
        protected virtual void Guardar_Click()
        {
            string VarIndicadorAnt = VarIndicador;
            try
            {
                string Errores = ComprobarInsertar();
                if ((Errores == "SIN ERRORES"))
                {
                    if ((VarIndicador == "MODIFICA"))
                    {
                        //Mensaje.Mostrar("Modificando...")
                        Modificar();
                        return;
                    }
                    if ((VarIndicador == "NUEVO"))
                    {
                        VarIndicador = "MODIFICA";
                        Insertar();
                    }
                    //DesHabilitar()
                    //Mensaje.MostrarFinal("Exito")
                }
                else
                {
                    //MsgBox(ComprobarInsertar(), MsgBoxStyle.Critical, "Error")
                    if (Errores != "SM")
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(Errores, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                //Mensaje.MostrarFinal("Error!")
                VarIndicador = VarIndicadorAnt;
                //MsgBox("Error de Programa: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Mensage(string Mensaje, string Titulo, System.Windows.Forms.MessageBoxButtons Botones, System.Windows.Forms.MessageBoxIcon Icono)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(Mensaje, Titulo, Botones, Icono);
        }
        protected virtual void Borrar_Click()
        {
            try
            {
                if ((ComprobarEliminar() == "SIN ERRORES"))
                {
                    DialogResult resp = new DialogResult();
                    resp = DevExpress.XtraEditors.XtraMessageBox.Show("¿Esta Seguro de Eliminar Este Registro?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        //Mensaje.Mostrar("Eliminando...")
                        Eliminar();
                        DesHabilitar();
                        NuevoButton();
                        VarIndicador = "NUEVO";
                        //Mensaje.MostrarFinal("Exito")
                    }
                }
                else
                {
                    //Mensaje.MostrarFinal("Error!")
                    //MsgBox(ComprobarEliminar(), MsgBoxStyle.Critical, "Error")
                    DevExpress.XtraEditors.XtraMessageBox.Show( ComprobarEliminar(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error de Programa: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " +"\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected virtual void Imprimir_Click()
        {
            try
            {
                if ((ComprobarImprimir() == "SIN ERRORES"))
                {
                    ImprimirReporte();
                }
                else
                {
                    // MsgBox(ComprobarImprimir(), MsgBoxStyle.Critical, "Error")
                    DevExpress.XtraEditors.XtraMessageBox.Show(ComprobarImprimir(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error de Programa: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected virtual void Proteger_Click()
        {
            try
            {
                if ((ComprobarProcesar() == "SIN ERRORES"))
                {
                    ProtegerTransaccion();
                }
                else
                {
                    //MsgBox(ComprobarProcesar(), MsgBoxStyle.Critical, "Error")
                    DevExpress.XtraEditors.XtraMessageBox.Show(ComprobarProcesar(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error de Programa: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarComboGenerico(System.Windows.Forms.ComboBox Combo, DataTable Data_Table, string DisplayMember, string valuemember)
        {
            try
            {
                Combo.DataSource = null;
                Combo.DisplayMember = DisplayMember;
                Combo.ValueMember = valuemember;
                Combo.DataSource = Data_Table;
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarLookEditDevExpress_Generico(LookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember)
        {
            try
            {
                LookEdit.Properties.DataSource = null;
                LookEdit.Properties.DataSource = Data_Table;
                LookEdit.Properties.DisplayMember = DisplayMember.ToUpper();
                LookEdit.Properties.ValueMember = valuemember.ToUpper();
                LookEdit.Properties.Columns.Clear();
                LookUpColumnInfoCollection coll = LookEdit.Properties.Columns;
                // A column to display the ProductID field's values.
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper()))
                    {
                        coll.Add(new LookUpColumnInfo(colum.ColumnName, 0));
                    }
                }
                LookEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                LookEdit.Properties.SearchMode = SearchMode.AutoFilter;
                LookEdit.Properties.AutoSearchColumnIndex = 0;
                LookEdit.Properties.CaseSensitiveSearch = false;
                if ((Data_Table.Rows.Count > 0))
                {
                    LookEdit.EditValue = Data_Table.Rows[0][valuemember];
                }
                else
                {
                    LookEdit.EditValue = 0;
                }
                if ((LookEdit.Properties.DropDownRows != 0))
                {
                    LookEdit.ItemIndex = 0;
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarLookEditDevExpress_Generico(LookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember, string Captions)
        {
            try
            {
                LookEdit.Properties.DataSource = null;
                LookEdit.Properties.DataSource = Data_Table;
                LookEdit.Properties.DisplayMember = DisplayMember.ToUpper();
                LookEdit.Properties.ValueMember = valuemember.ToUpper();
                LookEdit.Properties.Columns.Clear();
                LookUpColumnInfoCollection coll = LookEdit.Properties.Columns;
                // A column to display the ProductID field's values.
                string[] newline = Captions.Split(',');
                int index = 0;
                int indexc = 0;
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper()))
                    {
                        indexc = coll.Add(new LookUpColumnInfo(colum.ColumnName, 0));
                        LookEdit.Properties.Columns[indexc].Caption = newline[index].Trim();
                        index += 1;
                    }
                }
                LookEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                LookEdit.Properties.SearchMode = SearchMode.AutoFilter;
                LookEdit.Properties.AutoSearchColumnIndex = 0;
                LookEdit.Properties.CaseSensitiveSearch = false;
                if ((Data_Table.Rows.Count > 0))
                {
                    LookEdit.EditValue = Data_Table.Rows[0][valuemember];
                }
                else
                {
                    LookEdit.EditValue = 0;
                }
                if ((LookEdit.Properties.DropDownRows != 0))
                {
                    LookEdit.ItemIndex = 0;
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarLookEditDevExpress_Generico(SearchLookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember)
        {
            try
            {
                LookEdit.Properties.DataSource = Data_Table;
                LookEdit.Properties.DisplayMember = DisplayMember.ToUpper();
                LookEdit.Properties.ValueMember = valuemember.ToUpper();
                LookEdit.Properties.View.Columns.Clear();
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper()))
                    {
                        LookEdit.Properties.View.Columns.AddField(colum.ColumnName).Visible = true;
                    }
                }
                if ((Data_Table.Rows.Count > 0))
                {
                    LookEdit.EditValue = Data_Table.Rows[0][valuemember];
                    LookEdit.Properties.ShowClearButton = false;
                }
                else
                {
                    LookEdit.EditValue = 0;
                }

                //LookEdit.Properties.View.GetRow(LookEdit.Properties.GetIndexByKeyValue(Data_Table.Rows(0)(valuemember.ToString).ToString))
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarLookEditDevExpress_Generico(SearchLookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember, string Captions, string ColumnasOcultas = "")
        {
            try
            {
                LookEdit.Properties.DataSource = Data_Table;
                LookEdit.Properties.DisplayMember = DisplayMember.ToUpper();
                LookEdit.Properties.ValueMember = valuemember.ToUpper();
                LookEdit.Properties.View.Columns.Clear();
                LookEdit.Properties.View.OptionsView.RowAutoHeight = true;
                string[] newline = Captions.Split(',');
                int index = 0;
                ColumnasOcultas = ColumnasOcultas.ToUpper();
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper() & ColumnasOcultas.Split(',').Contains(colum.ColumnName.Trim()) == false))
                    {
                        LookEdit.Properties.View.Columns.AddField(colum.ColumnName).Caption = newline[index].Trim();
                        LookEdit.Properties.View.Columns[colum.ColumnName].Visible = true;
                        index += 1;
                    }

                }
                if ((Data_Table.Rows.Count > 0))
                {
                    LookEdit.EditValue = Data_Table.Rows[0][valuemember];
                    LookEdit.Properties.ShowClearButton = false;
                }
                else
                {
                    LookEdit.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarLookEditDevExpress_Generico(RepositoryItemSearchLookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember, string Captions)
        {
            try
            {
                LookEdit.DataSource = Data_Table;
                LookEdit.DisplayMember = DisplayMember.ToUpper();
                LookEdit.ValueMember = valuemember.ToUpper();
                LookEdit.View.Columns.Clear();
                string[] newline = Captions.Split(',');
                int index = 0;
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper()))
                    {
                        LookEdit.View.Columns.AddField(colum.ColumnName).Caption = newline[index].Trim();
                        LookEdit.View.Columns[colum.ColumnName].Visible = true;
                        index += 1;
                    }

                }
                if ((Data_Table.Rows.Count > 0))
                {
                    LookEdit.EditValueChangedDelay = 0;
                    LookEdit.EditValueChangedDelay = Convert.ToInt32(Data_Table.Rows[0][valuemember]);
                    LookEdit.ShowClearButton = false;
                }
                else
                {
                    LookEdit.EditValueChangedDelay = 0;
                }
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarLookEditDevExpress_Generico(RepositoryItemLookUpEdit LookEdit, DataTable Data_Table, string DisplayMember, string valuemember, string Captions)
        {
            try
            {
                LookEdit.DataSource = null;
                LookEdit.DataSource = Data_Table;
                LookEdit.DisplayMember = DisplayMember.ToUpper();
                LookEdit.ValueMember = valuemember.ToUpper();
                LookEdit.Columns.Clear();
                LookUpColumnInfoCollection coll = LookEdit.Columns;
                // A column to display the ProductID field's values.
                string[] newline = Captions.Split(',');
                int index = 0;
                int indexc = 0;
                foreach (DataColumn colum in Data_Table.Columns)
                {
                    if ((colum.ColumnName != valuemember.ToUpper()))
                    {
                        indexc = coll.Add(new LookUpColumnInfo(colum.ColumnName, 0));
                        LookEdit.Columns[indexc].Caption = newline[index].Trim();
                        index += 1;
                    }
                }
                LookEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                LookEdit.SearchMode = SearchMode.AutoFilter;
                LookEdit.AutoSearchColumnIndex = 0;
                LookEdit.CaseSensitiveSearch = false;
            }
            catch (Exception ex)
            {
                //MsgBox("Error: " & vbCrLf & ex.Message)
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + "\n" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public System.Drawing.Image CargarImagen(string RutaImagen)
        {
            if (( System.IO.File.Exists(RutaImagen)))
            {
                System.IO.StreamReader stream = new System.IO.StreamReader(RutaImagen);
                Image ImagenCapturada = Image.FromStream(stream.BaseStream);
                stream.Close();
                return ImagenCapturada;
            }
            return null;
        }
        public decimal SumarValoresFilaDatagrid(DataGridView Datagridview, int columna)
        {
            decimal Valor = 0;
            foreach (DataGridViewRow row in Datagridview.Rows)
            {
                Valor += Convert.ToDecimal(row.Cells[columna].Value.ToString());
            }
            return Valor;
        }

        private void Frm_Base_Load(object sender, EventArgs e)
        {
        }



        protected System.Drawing.Image Resizeimg(System.Drawing.Image image, System.Drawing.Size size, bool preserveAspectRatio = true)
        {
            if (image == null)
            {
                return null;
            }
            int newWidth = 0;
            int newHeight = 0;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = Convert.ToSingle(size.Width) / Convert.ToSingle(originalWidth);
                float percentHeight = Convert.ToSingle(size.Height) / Convert.ToSingle(originalHeight);
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = Convert.ToInt32(originalWidth * percent);
                newHeight = Convert.ToInt32(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            System.Drawing.Image newImage = new System.Drawing.Bitmap(newWidth, newHeight);
            using (System.Drawing.Graphics graphicsHandle = System.Drawing.Graphics.FromImage(newImage))
            {
                graphicsHandle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphicsHandle.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }
        //protected void GuardarImagendesdePictureEdit(DevExpress.XtraEditors.PictureEdit Picture, string Categoria, string Carpeta, string CodigoReferencia)
        //{
        //    CapaGeneral Negocio = new CapaGeneral();
        //    if (Picture.Image == null)
        //    {
        //        return;
        //    }
        //    int Codigo = 0;
        //    Bitmap ImagenGuardar = new Bitmap(Picture.Image);
        //    if (Negocio.ConsultaGeneral_ValorUnico("count(*)", "prg_v_img", "where referencia = '" + CodigoReferencia + "' and descripcion_categoria = '" + Categoria + "'", "").ToString().Trim() != "0")
        //    {
        //        DialogResult RespuestaMensaje = new DialogResult();
        //        RespuestaMensaje = DevExpress.XtraEditors.XtraMessageBox.Show("Ya tiene asignada una imagen ¿Desea cambiarla?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
        //        if (RespuestaMensaje == DialogResult.No)
        //        {
        //            return;
        //        }
        //        if (RespuestaMensaje == DialogResult.Yes)
        //        {
        //            Codigo = Convert.ToInt32(Negocio.ConsultaGeneral_ValorUnico("id_imagen", "prg_v_img", "where referencia = '" + CodigoReferencia + "' and descripcion_categoria = '" + Categoria + "'", ""));
        //            ImagenGuardar.Save(CarpetaArchivos + "\\Img\\" + Carpeta + "\\" + Codigo.ToString + ".png", ImageFormat.Png);
        //            return;
        //        }
        //    }
        //    Codigo = Negocio.InsertarImagen(Negocio.ConsultaGeneral_ValorUnico("id", "prg_catimg", "where descripcion = '" + Categoria + "'", "").ToString(), CodigoReferencia);
        //    ImagenGuardar.Save(CarpetaArchivos + "\\Img\\" + Carpeta + "\\" + Codigo.ToString + ".png", ImageFormat.Png);
        //}

        //protected void CargarImagenesparaPictureEdit(DevExpress.XtraEditors.PictureEdit Picture, string Categoria, string Carpeta, string CodigoReferencia)
        //{
        //    CapaGeneral Negocio = new CapaGeneral();
        //    string RutaImagen = CarpetaArchivos + "\\Img\\" + Carpeta + "";
        //    RutaImagen = RutaImagen + "\\" + Negocio.ConsultaGeneral_ValorUnico("id_imagen", "prg_v_img", "where referencia = '" + CodigoReferencia + "' and descripcion_categoria = '" + Categoria + "'", "") + ".png";
        //    Picture.Image = CargarImagen(RutaImagen);
        //}
        //public DataTable CargarDataTableVacioconDataLLeno(DataTable DataLleno, int PosicionImagen = -1, string ColumnaImagen = "", string CategoriaImagen = "", string CarpetaImagen = "")
        //{
        //    int Posicion = PosicionImagen;
        //    int cont = -1;
        //    int contimg = 0;
        //    DataTable DataFinal = new DataTable();
        //    foreach (DataColumn colum in DataLleno.Columns)
        //    {
        //        cont += 1;
        //        DataFinal.Columns.Add();
        //        DataFinal.Columns[DataFinal.Columns.Count - 1].ColumnName = colum.ColumnName;
        //        DataFinal.Columns[DataFinal.Columns.Count - 1].Namespace = colum.ColumnName;
        //        if (Posicion == cont + 1)
        //        {
        //            DataFinal.Columns.Add("Imagen", typeof(Image));
        //            DataFinal.Columns[Posicion].ColumnName = "Imagen";
        //            DataFinal.Columns[Posicion].Namespace = "Imagen";
        //        }

        //    }
        //    foreach (DataRow fila in DataLleno.Rows)
        //    {
        //        DataFinal.Rows.Add();
        //        if (Posicion != -1)
        //        {
        //            DataFinal.Rows[DataFinal.Rows.Count - 1]["Imagen"] = CargarImagenBusq(fila[ColumnaImagen].ToString(), CategoriaImagen, CarpetaImagen);
        //        }

        //        foreach (DataColumn colum in DataLleno.Columns)
        //        {
        //            DataFinal.Rows[DataFinal.Rows.Count - 1][colum.ColumnName] = fila[colum.ColumnName];
        //        }
        //    }
        //    return DataFinal;
        //}
        //public System.Drawing.Image CargarImagenBusq(string idImagen, string categoria, string carpeta)
        //{
        //    CapaGeneral Negocio = new CapaGeneral();
        //    DataTable ImagenTabla = Negocio.ConsultaGeneralOracle("id_imagen", "prg_v_img", "where referencia = '" + idImagen + "' and descripcion_categoria = '" + categoria + "'", "");
        //    if (ImagenTabla.Rows.Count != 0)
        //    {
        //        string RutaImagen = CarpetaArchivos + "\\Img\\" + carpeta + "\\" + ImagenTabla.Rows[0]["id_imagen"].ToString + ".png";
        //        if (( System.IO.File.Exists(RutaImagen)))
        //        {
        //            System.IO.StreamReader stream = new System.IO.StreamReader(RutaImagen);
        //            Image ImagenCapturada = Image.FromStream(stream.BaseStream);
        //            stream.Close();
        //            return ImagenCapturada;
        //        }
        //        return null;
        //    }
        //    return null;
        //}
        public DataTable DevuelveTablaConEstructura(DevExpress.XtraGrid.GridControl GridControl, DevExpress.XtraGrid.Views.Grid.GridView GridView)
        {
            DataTable Tabla = new DataTable();

            foreach (DevExpress.XtraGrid.Columns.GridColumn columna in GridView.Columns)
            {
                Tabla.Columns.Add(columna.FieldName, columna.ColumnType);
            }
            return Tabla;
        }
        public DataTable DevuelveTablaConEstructura(string NameData, DevExpress.XtraGrid.GridControl GridControl, DevExpress.XtraGrid.Views.Grid.GridView GridView)
        {
            DataTable Tabla = new DataTable(NameData);

            foreach (DevExpress.XtraGrid.Columns.GridColumn columna in GridView.Columns)
            {
                Tabla.Columns.Add(columna.FieldName, columna.ColumnType);
            }
            return Tabla;
        }
        public int obtenerindicededatatable(DataTable TablaDatos, object valoraBuscar, string ColumnadeBusqueda)
        {
            int cont = -1;
            foreach (DataRow valor in TablaDatos.Rows)
            {
                cont += 1;
                if (valor[ColumnadeBusqueda].ToString().Trim() == valoraBuscar.ToString().Trim())
                {
                    return cont;
                }
            }
            return -1;
        }
        public string FechaVb_FechaAccess(DateTime fecha, string FormatoVisual, string FormatoAcess)
        {
            return "FORMAT('" + fecha.ToString(FormatoVisual, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) +"' , \"" + FormatoAcess + "\"" + ")";
        }
    }
}