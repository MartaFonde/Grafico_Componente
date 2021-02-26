
namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEjeX = new System.Windows.Forms.TextBox();
            this.txtEjeY = new System.Windows.Forms.TextBox();
            this.btnAceptarTxtX = new System.Windows.Forms.Button();
            this.btnAceptarTxtY = new System.Windows.Forms.Button();
            this.rbBarras = new System.Windows.Forms.RadioButton();
            this.rbLinea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptarTamanho = new System.Windows.Forms.Button();
            this.txtTamanhoX = new System.Windows.Forms.TextBox();
            this.txtTamanhoY = new System.Windows.Forms.TextBox();
            this.grafico = new GraficoBarrasComponente.GraficoBarras();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Texto Y";
            // 
            // txtEjeX
            // 
            this.txtEjeX.Location = new System.Drawing.Point(534, 260);
            this.txtEjeX.Name = "txtEjeX";
            this.txtEjeX.Size = new System.Drawing.Size(100, 20);
            this.txtEjeX.TabIndex = 10;
            // 
            // txtEjeY
            // 
            this.txtEjeY.Location = new System.Drawing.Point(534, 311);
            this.txtEjeY.Name = "txtEjeY";
            this.txtEjeY.Size = new System.Drawing.Size(100, 20);
            this.txtEjeY.TabIndex = 11;
            // 
            // btnAceptarTxtX
            // 
            this.btnAceptarTxtX.Location = new System.Drawing.Point(645, 260);
            this.btnAceptarTxtX.Name = "btnAceptarTxtX";
            this.btnAceptarTxtX.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarTxtX.TabIndex = 12;
            this.btnAceptarTxtX.Text = "Aceptar";
            this.btnAceptarTxtX.UseVisualStyleBackColor = true;
            this.btnAceptarTxtX.Click += new System.EventHandler(this.btnAceptarTxtX_Click);
            // 
            // btnAceptarTxtY
            // 
            this.btnAceptarTxtY.Location = new System.Drawing.Point(645, 311);
            this.btnAceptarTxtY.Name = "btnAceptarTxtY";
            this.btnAceptarTxtY.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarTxtY.TabIndex = 13;
            this.btnAceptarTxtY.Text = "Aceptar";
            this.btnAceptarTxtY.UseVisualStyleBackColor = true;
            this.btnAceptarTxtY.Click += new System.EventHandler(this.btnAceptarTxtY_Click);
            // 
            // rbBarras
            // 
            this.rbBarras.AutoSize = true;
            this.rbBarras.Location = new System.Drawing.Point(23, 45);
            this.rbBarras.Name = "rbBarras";
            this.rbBarras.Size = new System.Drawing.Size(55, 17);
            this.rbBarras.TabIndex = 14;
            this.rbBarras.TabStop = true;
            this.rbBarras.Text = "Barras";
            this.rbBarras.UseVisualStyleBackColor = true;
            this.rbBarras.CheckedChanged += new System.EventHandler(this.rbBarras_CheckedChanged);
            // 
            // rbLinea
            // 
            this.rbLinea.AutoSize = true;
            this.rbLinea.Location = new System.Drawing.Point(25, 19);
            this.rbLinea.Name = "rbLinea";
            this.rbLinea.Size = new System.Drawing.Size(53, 17);
            this.rbLinea.TabIndex = 15;
            this.rbLinea.TabStop = true;
            this.rbLinea.Text = "Línea";
            this.rbLinea.UseVisualStyleBackColor = true;
            this.rbLinea.CheckedChanged += new System.EventHandler(this.rbLinea_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLinea);
            this.groupBox1.Controls.Add(this.rbBarras);
            this.groupBox1.Location = new System.Drawing.Point(51, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de gráfico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.rbAutomatico);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(23, 44);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Location = new System.Drawing.Point(23, 20);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatico.TabIndex = 0;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automático";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            this.rbAutomatico.CheckedChanged += new System.EventHandler(this.rbAutomatico_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Y";
            // 
            // btnAceptarTamanho
            // 
            this.btnAceptarTamanho.Location = new System.Drawing.Point(534, 32);
            this.btnAceptarTamanho.Name = "btnAceptarTamanho";
            this.btnAceptarTamanho.Size = new System.Drawing.Size(136, 31);
            this.btnAceptarTamanho.TabIndex = 20;
            this.btnAceptarTamanho.Text = "Cambiar tamaño";
            this.btnAceptarTamanho.UseVisualStyleBackColor = true;
            this.btnAceptarTamanho.Click += new System.EventHandler(this.btnAceptarTamanho_Click);
            // 
            // txtTamanhoX
            // 
            this.txtTamanhoX.Location = new System.Drawing.Point(433, 26);
            this.txtTamanhoX.Name = "txtTamanhoX";
            this.txtTamanhoX.Size = new System.Drawing.Size(58, 20);
            this.txtTamanhoX.TabIndex = 21;
            // 
            // txtTamanhoY
            // 
            this.txtTamanhoY.Location = new System.Drawing.Point(433, 58);
            this.txtTamanhoY.Name = "txtTamanhoY";
            this.txtTamanhoY.Size = new System.Drawing.Size(58, 20);
            this.txtTamanhoY.TabIndex = 22;
            // 
            // grafico
            // 
            this.grafico.EjeX = 1;
            this.grafico.EjeY = 0;
            this.grafico.ForeColor = System.Drawing.Color.IndianRed;
            this.grafico.Location = new System.Drawing.Point(12, 104);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(425, 334);
            this.grafico.TabIndex = 1;
            this.grafico.Text = "graficoBarras2";
            this.grafico.TipoGrafico = GraficoBarrasComponente.eTipoGrafico.BARRAS;
            this.grafico.TipoTamaño = GraficoBarrasComponente.eTipoTamaño.Automático;
            this.grafico.TxtX = null;
            this.grafico.TxtY = null;
            this.grafico.Valores = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTamanhoY);
            this.Controls.Add(this.txtTamanhoX);
            this.Controls.Add(this.btnAceptarTamanho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptarTxtY);
            this.Controls.Add(this.btnAceptarTxtX);
            this.Controls.Add(this.txtEjeY);
            this.Controls.Add(this.txtEjeX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grafico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GraficoBarrasComponente.GraficoBarras grafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEjeX;
        private System.Windows.Forms.TextBox txtEjeY;
        private System.Windows.Forms.Button btnAceptarTxtX;
        private System.Windows.Forms.Button btnAceptarTxtY;
        private System.Windows.Forms.RadioButton rbBarras;
        private System.Windows.Forms.RadioButton rbLinea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptarTamanho;
        private System.Windows.Forms.TextBox txtTamanhoX;
        private System.Windows.Forms.TextBox txtTamanhoY;
    }
}

