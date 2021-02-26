using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            grafico.Valores = new List<int>();
            grafico.Valores.Add(4);
            grafico.Valores.Add(6);
            grafico.Valores.Add(8);
            grafico.Valores.Add(2);
            grafico.Valores.Add(9);
            grafico.Valores.Add(6);
            grafico.Valores.Add(3);                   
            
            rbAutomatico.Checked = true;           
            rbBarras.Checked = true;

        }

        private void rbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            grafico.TipoTamaño = GraficoBarrasComponente.eTipoTamaño.Automático;
            grafico.EjeX = grafico.Valores.Count;
            grafico.EjeY = grafico.Valores.Max();
            txtTamanhoX.Text = grafico.Valores.Count.ToString();
            txtTamanhoY.Text = grafico.Valores.Max().ToString();
            txtTamanhoX.Enabled = false;
            txtTamanhoY.Enabled = false;
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            grafico.TipoTamaño = GraficoBarrasComponente.eTipoTamaño.Manual;
            txtTamanhoX.Enabled = true;
            txtTamanhoY.Enabled = true;
        }

        private void rbBarras_CheckedChanged(object sender, EventArgs e)
        {
            grafico.TipoGrafico = GraficoBarrasComponente.eTipoGrafico.BARRAS;
        }

        private void rbLinea_CheckedChanged(object sender, EventArgs e)
        {
            grafico.TipoGrafico = GraficoBarrasComponente.eTipoGrafico.LINEA;
        }

        private void btnAceptarTamanho_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtTamanhoX.Text);
            if(x > 0 && x <= grafico.Valores.Count)
            {
                grafico.EjeX = x;
            }
            int y = Convert.ToInt32(txtTamanhoY.Text);
            if(y > 0)
            {
                grafico.EjeY = y;
            }            
        }

        private void btnAceptarTxtX_Click(object sender, EventArgs e)
        {
            grafico.TxtX = txtEjeX.Text;
        }

        private void btnAceptarTxtY_Click(object sender, EventArgs e)
        {
            grafico.TxtY = txtEjeY.Text;
        }
    }
}
