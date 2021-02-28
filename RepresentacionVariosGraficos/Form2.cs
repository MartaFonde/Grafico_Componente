using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepresentacionVariosGraficos
{
    public partial class Form2 : Form
    {
        string color;
        public Form2(string filas, string col, string tipoGrafico, string colorLinea)
        {
            InitializeComponent();
            cbFilas.SelectedItem = filas;
            cbColumnas.SelectedItem = col;
            color = colorLinea;

            if(tipoGrafico == "BARRAS")
            {
                rbBarras.Checked = true;
                lbColores.Enabled = false;
            }
            else
            {
                rbLinea.Checked = true;
                selectColor();                
            }           
        }

        private void rbLinea_CheckedChanged(object sender, EventArgs e)
        {
            lbColores.Enabled = rbLinea.Checked;
            selectColor();
        }

        private void selectColor()
        {
            switch (color)
            {
                case "Color [Black]":
                    lbColores.SelectedIndex = 0;
                    break;
                case "Color [Red]":
                    lbColores.SelectedIndex = 1;
                    break;
                case "Color [Blue]":
                    lbColores.SelectedIndex = 2;
                    break;
                case "Color [Green]":
                    lbColores.SelectedIndex = 3;
                    break;
                case "Color [Yellow]":
                    lbColores.SelectedIndex = 4;
                    break;
            }
        }
    }
}
