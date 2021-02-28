using GraficoBarrasComponente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestForm
{
    public partial class Form1 : Form
    {
        List<GraficoBarras> graficos;
        int filas = 1;
        int columnas = 3; 

        public Form1()
        {
            InitializeComponent();

            grafico.Valores = new List<double>();
            grafico.Valores.Add(4.5);
            grafico.Valores.Add(6.1);
            grafico.Valores.Add(8);
            grafico.Valores.Add(2.5);
            grafico.Valores.Add(9.5);
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

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Todos los archivos|*.*|XML|*.xml";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                int i = -1;
                graficos = new List<GraficoBarras>();
                bool correcto = true;
                try
                {                    
                    using (XmlReader reader = XmlReader.Create(openFile.FileName))
                    {
                        while (reader.Read())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "grafico":
                                    graficos.Add(new GraficoBarras());
                                    i++;
                                    break;
                                case "nombre":
                                    graficos[i].Name = reader.ReadElementContentAsString();
                                    break;
                                case "txtX":
                                    graficos[i].TxtX = reader.ReadElementContentAsString();
                                    break;
                                case "txtY":
                                    graficos[i].TxtY = reader.ReadElementContentAsString();
                                    break;
                                case "dato":
                                    graficos[i].Valores.Add(reader.ReadElementContentAsDouble());
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    correcto = false;
                    Console.WriteLine(ex.Message);                    
                }

                if (correcto)
                {
                    float propW = this.Width / columnas;
                    float propH = this.Height / filas;

                }
            }           
        }
    }
}
