
namespace gestorLollapalooza.presLayer.ReportPres
{
    partial class frmReporteGM
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
            this.reportViewerGM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetGruposMusicales = new gestorLollapalooza.ReportLayer.DataSetLollaPalooza();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCantIntegrantesMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCantidadIntegrantesMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbTraerTodos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadIntegrantesMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerGM
            // 
            this.reportViewerGM.LocalReport.ReportEmbeddedResource = "gestorLollapalooza.ReportLayer.ReportGruposMusicales.rdlc";
            this.reportViewerGM.Location = new System.Drawing.Point(16, 201);
            this.reportViewerGM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewerGM.Name = "reportViewerGM";
            this.reportViewerGM.ServerReport.BearerToken = null;
            this.reportViewerGM.Size = new System.Drawing.Size(1139, 505);
            this.reportViewerGM.TabIndex = 0;
            // 
            // dataSetGruposMusicales
            // 
            this.dataSetGruposMusicales.DataSetName = "DataSetGruposMusicales";
            this.dataSetGruposMusicales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "GrupoMusical";
            this.dataTable1BindingSource.DataSource = this.dataSetGruposMusicales;
            // 
            // numCantIntegrantesMin
            // 
            this.numCantIntegrantesMin.Location = new System.Drawing.Point(263, 32);
            this.numCantIntegrantesMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCantIntegrantesMin.Name = "numCantIntegrantesMin";
            this.numCantIntegrantesMin.Size = new System.Drawing.Size(160, 22);
            this.numCantIntegrantesMin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de integrantes mínima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de integrantes máxima: ";
            // 
            // numCantidadIntegrantesMax
            // 
            this.numCantidadIntegrantesMax.Location = new System.Drawing.Point(263, 68);
            this.numCantidadIntegrantesMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCantidadIntegrantesMax.Name = "numCantidadIntegrantesMax";
            this.numCantidadIntegrantesMax.Size = new System.Drawing.Size(160, 22);
            this.numCantidadIntegrantesMax.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbTraerTodos);
            this.groupBox1.Controls.Add(this.numCantidadIntegrantesMax);
            this.groupBox1.Controls.Add(this.numCantIntegrantesMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(431, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chbTraerTodos
            // 
            this.chbTraerTodos.AutoSize = true;
            this.chbTraerTodos.Location = new System.Drawing.Point(263, 126);
            this.chbTraerTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTraerTodos.Name = "chbTraerTodos";
            this.chbTraerTodos.Size = new System.Drawing.Size(104, 21);
            this.chbTraerTodos.TabIndex = 8;
            this.chbTraerTodos.Text = "Traer todos";
            this.chbTraerTodos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(959, 53);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(139, 60);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Generar Reporte";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmReporteGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1172, 721);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerGM);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteGM";
            this.Text = "Formulario de grupos musicales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadIntegrantesMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGM;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ReportLayer.DataSetLollaPalooza dataSetGruposMusicales;
        private System.Windows.Forms.NumericUpDown numCantIntegrantesMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCantidadIntegrantesMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private BotonFacha btnConsultar;
        private System.Windows.Forms.CheckBox chbTraerTodos;
    }
}