
namespace RepresentacionVariosGraficos
{
    partial class Form2
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
            this.cbColumnas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilas = new System.Windows.Forms.ComboBox();
            this.rbBarras = new System.Windows.Forms.RadioButton();
            this.rbLinea = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbColumnas
            // 
            this.cbColumnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumnas.FormattingEnabled = true;
            this.cbColumnas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbColumnas.Location = new System.Drawing.Point(193, 85);
            this.cbColumnas.Name = "cbColumnas";
            this.cbColumnas.Size = new System.Drawing.Size(121, 21);
            this.cbColumnas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de columnas por fila";
            // 
            // cbFilas
            // 
            this.cbFilas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbFilas.Location = new System.Drawing.Point(193, 33);
            this.cbFilas.Name = "cbFilas";
            this.cbFilas.Size = new System.Drawing.Size(121, 21);
            this.cbFilas.TabIndex = 3;
            // 
            // rbBarras
            // 
            this.rbBarras.AutoSize = true;
            this.rbBarras.Checked = true;
            this.rbBarras.Location = new System.Drawing.Point(194, 147);
            this.rbBarras.Name = "rbBarras";
            this.rbBarras.Size = new System.Drawing.Size(55, 17);
            this.rbBarras.TabIndex = 4;
            this.rbBarras.TabStop = true;
            this.rbBarras.Text = "Barras";
            this.rbBarras.UseVisualStyleBackColor = true;
            // 
            // rbLinea
            // 
            this.rbLinea.AutoSize = true;
            this.rbLinea.Location = new System.Drawing.Point(264, 147);
            this.rbLinea.Name = "rbLinea";
            this.rbLinea.Size = new System.Drawing.Size(51, 17);
            this.rbLinea.TabIndex = 5;
            this.rbLinea.Text = "Linea";
            this.rbLinea.UseVisualStyleBackColor = true;
            this.rbLinea.CheckedChanged += new System.EventHandler(this.rbLinea_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de gráfico";
            // 
            // lbColores
            // 
            this.lbColores.FormattingEnabled = true;
            this.lbColores.Items.AddRange(new object[] {
            "Negro",
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo"});
            this.lbColores.Location = new System.Drawing.Point(194, 209);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(120, 95);
            this.lbColores.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color de línea";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(162, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbColores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbLinea);
            this.Controls.Add(this.rbBarras);
            this.Controls.Add(this.cbFilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColumnas);
            this.Name = "Form2";
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.ComboBox cbColumnas;
        internal System.Windows.Forms.ComboBox cbFilas;
        internal System.Windows.Forms.RadioButton rbBarras;
        internal System.Windows.Forms.RadioButton rbLinea;
        internal System.Windows.Forms.ListBox lbColores;
    }
}