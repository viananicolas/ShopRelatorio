namespace ShopRelatorios
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AnaliseEstoqueViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSubClasse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbFabricantes = new System.Windows.Forms.ComboBox();
            this.fabricantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFiliais = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseEstoqueViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AnaliseEstoqueViewModelBindingSource
            // 
            this.AnaliseEstoqueViewModelBindingSource.DataSource = typeof(ShopRelatorios.DAL.ViewModels.AnaliseEstoqueViewModel);
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(13, 32);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbClasse.TabIndex = 0;
            // 
            // cmbSubClasse
            // 
            this.cmbSubClasse.FormattingEnabled = true;
            this.cmbSubClasse.Location = new System.Drawing.Point(13, 81);
            this.cmbSubClasse.Name = "cmbSubClasse";
            this.cmbSubClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbSubClasse.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(140, 33);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(89, 20);
            this.dtpInicio.TabIndex = 4;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(140, 82);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(89, 20);
            this.dtpFinal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subclasse";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data fim";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "VendaDataSet";
            reportDataSource1.Value = this.AnaliseEstoqueViewModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopRelatorios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1091, 379);
            this.reportViewer1.TabIndex = 10;
            // 
            // cmbFabricantes
            // 
            this.cmbFabricantes.FormattingEnabled = true;
            this.cmbFabricantes.Location = new System.Drawing.Point(235, 32);
            this.cmbFabricantes.Name = "cmbFabricantes";
            this.cmbFabricantes.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricantes.TabIndex = 11;
            // 
            // fabricantesBindingSource
            // 
            this.fabricantesBindingSource.DataSource = typeof(ShopRelatorios.DAL.Models.Fabricantes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fabricante";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(235, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Não listar sugestões zeradas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filiais";
            // 
            // cmbFiliais
            // 
            this.cmbFiliais.FormattingEnabled = true;
            this.cmbFiliais.Location = new System.Drawing.Point(362, 32);
            this.cmbFiliais.Name = "cmbFiliais";
            this.cmbFiliais.Size = new System.Drawing.Size(121, 21);
            this.cmbFiliais.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 528);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFiliais);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFabricantes);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSubClasse);
            this.Controls.Add(this.cmbClasse);
            this.Name = "Form1";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseEstoqueViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSubClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AnaliseEstoqueViewModelBindingSource;
        private System.Windows.Forms.ComboBox cmbFabricantes;
        private System.Windows.Forms.BindingSource fabricantesBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFiliais;
    }
}

