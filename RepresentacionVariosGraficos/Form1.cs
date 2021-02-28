using GraficoBarrasComponente;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RepresentacionVariosGraficos
{
    public partial class Form1 : Form
    {
        List<GraficoBarras> graficos;
        int filas = 2;
        int columnas = 3;
        eTipoGrafico tipo = eTipoGrafico.BARRAS;
        Color colorLinea = Color.Black;

        public Form1()
        {
            InitializeComponent();
            leerConfig();
        }

        private void abrir(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Json|*.json|XML|*.xml|Todos los archivos|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(openFile.FileName);
                if(f.Extension == ".xml")
                {
                    if (leerXml(openFile.FileName))
                    {
                        crearGraficos();
                    }                    
                }
                else if(f.Extension == ".json")
                {
                    if (leerJson(openFile.FileName))
                    {
                        crearGraficos();
                    }
                }
            }
        }

        private bool leerXml(string file)
        {
            int i = -1;
            graficos = new List<GraficoBarras>();

            try
            {
                using (XmlReader reader = XmlReader.Create(file))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())        //return only when you have START tag
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer xml: " + ex.Message);
                return false;
            }
            MessageBox.Show(graficos.Count + "");

            return true;
        }

        private bool leerJson(string file)
        {
            int i = -1;
            graficos = new List<GraficoBarras>();
            try
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    string ob = sr.ReadToEnd();
                    JArray g = JArray.Parse(ob);
                    foreach (JObject o in g.Children<JObject>())
                    {
                        graficos.Add(new GraficoBarras());
                        i++;
                        foreach (JProperty p in o.Properties())
                        {
                            switch (p.Name)
                            {
                                case "nombre": graficos[i].Name = (string)p.Value;
                                    break;
                                case "txtX": graficos[i].TxtX = (string)p.Value;
                                    break;
                                case "txtY": graficos[i].TxtY = (string)p.Value;
                                    break;
                                case "datos":
                                    foreach (double v in p.Values())
                                    {
                                        graficos[i].Valores.Add((double)v);
                                    }
                                    break;
                            }
                        }
                    }                    
                }
            }                      
            catch(IOException ex)
            {
                MessageBox.Show("Error al leer json: "+ex.Message);
                return false;
            }
            catch (Exception js)
            {
                MessageBox.Show("Error parse JObj: " + js);
                return false;
            }
            MessageBox.Show(graficos.Count+"");
            return true;
        }

        private void crearGraficos()
        {            
            foreach (Control g in Controls)
            {
                if(g is GraficoBarras || g is Label)
                {
                    this.Controls.Remove(g);
                }
            }

            Label lbl;
            int propW = this.Width / columnas;
            int propH = this.Height / filas;
            int c = 0; //col actual
            int f = 0; //fila actual            

            foreach (GraficoBarras g in graficos)
            {
                g.TipoGrafico = tipo;
                g.ForeColor = colorLinea;
                g.Width = propW - 50;
                g.Height = propH - 50;
                lbl = new Label();
                lbl.Text = g.Name;
                lbl.ForeColor = Color.Black;
                lbl.AutoSize = true;

                if (f == 0)
                {
                    g.Location = new Point(propW * c + 20, 50); //30 de menú
                    if (c == 0)
                    {
                        lbl.Location = new Point(propW / 3, g.Location.Y - 15);
                    }
                    else
                    {
                        lbl.Location = new Point(g.Location.X + g.Location.X / (3 * c), g.Location.Y - 15);
                    }
                }
                else
                {
                    g.Location = new Point(propW * c + 20, propH * f + 20); //30 de menú
                    if (c == 0)
                    {
                        lbl.Location = new Point(propW / 3 + 20, g.Location.Y - 15);
                    }
                    else
                    {
                        lbl.Location = new Point(g.Location.X + g.Location.X / 3, propH * f + 20);
                    }

                    //lbl.Location = new Point(g.Location.X + g.Location.X / 3, g.Location.Y - 15);
                }
                c++;
                if (c == columnas)
                {
                    c = 0;
                    f++;
                }
                this.Controls.Add(g);
                this.Controls.Add(lbl);

                if(f == filas - 1)
                {
                    break;
                }
                
            }
        }

        private void configurar(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(filas.ToString(), columnas.ToString(), tipo.ToString(), colorLinea.ToString());

            if(f2.ShowDialog() == DialogResult.OK)
            {
                filas = Convert.ToInt32(f2.cbFilas.SelectedItem.ToString());
                columnas = Convert.ToInt32(f2.cbColumnas.SelectedItem.ToString());
                tipo = f2.rbBarras.Checked ? eTipoGrafico.BARRAS : eTipoGrafico.LINEA;

                if(tipo == eTipoGrafico.LINEA)
                {
                    switch (f2.lbColores.SelectedItem.ToString())
                    {
                        case "Negro":
                            colorLinea = Color.Black;
                            break;
                        case "Rojo":
                            colorLinea = Color.Red;
                            break;
                        case "Azul":
                            colorLinea = Color.Blue;
                            break;
                        case "Verde":
                            colorLinea = Color.Green;
                            break;
                        case "Amarillo":
                            colorLinea = Color.Yellow;
                            break;
                    }
                }
                
                guardarConfig(filas.ToString(), columnas.ToString(), tipo.ToString(), colorLinea.ToString());

                if(graficos != null)
                {
                    crearGraficos();
                }                
            }
        }

        private void guardarConfig(string filas, string col, string tipo, string colorLinea)
        {            
            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "\\" + "graficosConfig.txt"))
                {
                    sw.WriteLine(filas);
                    sw.WriteLine(col);
                    sw.WriteLine(tipo);
                    sw.WriteLine(colorLinea);
                }
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show("Error acceso a %appdata% : "+exc.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al escribir configuración en fichero: "+ex.Message);
            }
        }

        private void leerConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Environment.GetEnvironmentVariable("appdata")+"\\"+"graficosConfig.txt"))
                {
                    filas = Convert.ToInt32(sr.ReadLine());
                    columnas = Convert.ToInt32(sr.ReadLine());
                    tipo = sr.ReadLine() == "BARRAS" ? eTipoGrafico.BARRAS : eTipoGrafico.LINEA;
                    switch(sr.ReadLine()) {
                        case "Color [Black]": colorLinea = Color.Black;
                            break;
                        case "Color [Red]":
                            colorLinea = Color.Red;
                            break;
                        case "Color [Blue]":
                            colorLinea = Color.Blue;
                            break;
                        case "Color [Green]":
                            colorLinea = Color.Green;
                            break;
                        case "Color [Yellow]":
                            colorLinea = Color.Yellow;
                            break;
                    }
                }
            }
            catch(FileNotFoundException f)
            {
                MessageBox.Show("El fichero de config no existe: " + f.Message);
            }
            
            catch(IOException ex)
            {
                MessageBox.Show("Error al leer fichero de configuración: " + ex.Message);
            }
        }

        private void salir(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
}
