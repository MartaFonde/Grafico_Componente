using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficoBarrasComponente
{
    public enum eTipoTamaño
    {
        Manual,
        Automático
    }

    public enum eTipoGrafico
    {
        BARRAS,
        LINEA
    }

    [
       DefaultProperty("TipoGrafico"),
       DefaultEvent("Load")
    ]
    public partial class GraficoBarras : Control
    {
        private Color[] colores = { Color.Green, Color.Blue, Color.Yellow };

        
        private List<double> valores;
        [Category("Design")]
        [Description("Valores representados en la gráfica")]
        public List<double> Valores
        {
            set
            {
                valores = value;
                Refresh();
            }
            get
            {
                return valores;
            }
        }

        
        private double ejeX;
        [Category("Design")]
        [Description("Tamaño eje x")]
        public double EjeX
        {
            set
            {
                if(tipoTamaño == eTipoTamaño.Manual)
                {
                    try
                    {
                        Convert.ToDouble(value);
                        if(value > 0 && value <= Valores.Count)
                        {
                            ejeX = value;
                            Refresh();
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }

                    }
                    catch (FormatException)
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    if(Valores != null)
                    {
                        ejeX = Valores.Count();
                    }                    
                    Refresh();
                }
            }
            get
            {
                return ejeX;
            }
        }

        
        private double ejeY;
        [Category("Design")]
        [Description("Tamaño del eje y")]
        public double EjeY
        {
            set
            {
                if (tipoTamaño == eTipoTamaño.Manual)
                {
                    try
                    {
                        Convert.ToDouble(value);
                        if(value > 0)
                        {
                            ejeY = value;
                            Refresh();
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (FormatException)
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    if(Valores != null)
                    {
                        ejeY = Valores.Max();
                    }                    
                    Refresh();
                }
            }
            get
            {
                return ejeY;
            }
        }

        
        private eTipoTamaño tipoTamaño;
        [Category("Design")]
        [Description("Tipo de tamaño del gráfico")]
        public eTipoTamaño TipoTamaño
        {
            set
            {
                if(Enum.IsDefined(typeof(eTipoTamaño), value)){
                    tipoTamaño = value;
                    Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return tipoTamaño;
            }
        }
        
        private string txtX;
        [Category("Appearance")]
        [Description("Texto que informa de lo que es el eje x")]
        public string TxtX
        {
            set
            {
                txtX = value;
                Refresh();
            }
            get
            {
                return txtX;
            }
        }
        
        private string txtY;
        [Category("Appearance")]
        [Description("Texto que informa de lo que es el eje y")]
        public string TxtY
        {
            set
            {
                txtY = value;
                Refresh();
            }
            get
            {
                return txtY;
            }
        }
        
        private eTipoGrafico tipoGrafico;
        [Category("Appearance")]
        [Description("Tipo de gráfico")]
        public eTipoGrafico TipoGrafico
        {
            set
            {
                if(Enum.IsDefined(typeof(eTipoGrafico), value)){
                    tipoGrafico = value;
                    Refresh();
                }
            }
            get
            {
                return tipoGrafico;
            }
        }

        public GraficoBarras()
        {
            InitializeComponent();

            Valores = new List<double>();
            //Valores.Add(0);
            TipoTamaño = eTipoTamaño.Automático;
            TipoGrafico = eTipoGrafico.BARRAS;            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            float propW = this.Width / 20;
            float propH = this.Height / 14;

            Pen p = new Pen(Color.Black);
            Pen pLineas = new Pen(this.ForeColor);
            SolidBrush b = new SolidBrush(Color.Black);

            g.DrawLine(p, new PointF(propW * 2, propH * 2), new PointF(propW * 2, this.Height - propH * 2));
            g.DrawLine(p, new PointF(propW * 2, this.Height - propH * 2), 
                new PointF(this.Width - propW * 2, this.Height - propH * 2));

            if(TxtX != null)
            {
                g.DrawString(TxtX, this.Font, b, new PointF(this.Width - propW * 3, this.Height - propH * 1.5f));
            }

            if(TxtY != null)
            {
                g.TranslateTransform(propW , propH * 4);
                g.RotateTransform(-90);
                g.DrawString(TxtY, this.Font, b, new PointF(0, 0));
                g.ResetTransform();
            }

            if(Valores != null)
            {
                float maxX;
                float maxY;

                if (TipoTamaño == eTipoTamaño.Automático)
                {
                    maxX = Valores.Count;
                    maxY = (float)Valores.Max();
                }
                else
                {
                    maxX = (float)EjeX;
                    maxY = (float)EjeY;
                }

                float widthGrafica = this.Width - 4 * propW;
                float heightGrafica = this.Height - 4 * propH;

                float propWGrafica = widthGrafica / (maxX * 2);
                float propHGrafica = heightGrafica / maxY;

                float x = propW * 2 ;

                if (TipoGrafico == eTipoGrafico.BARRAS)
                {
                    int c = 0;
                    for (int i = 0; i < maxX; i++)
                    {
                        float y = (float)(this.Height - 2 * propH - Valores[i] * propHGrafica);

                        if (Valores[i] > maxY)
                        {
                            y = this.Height - 2 * propH - propHGrafica * maxY;
                            b.Color = Color.Red;
                            e.Graphics.FillRectangle(b, new RectangleF(x, y, propWGrafica, propHGrafica * maxY));
                        }
                        else
                        {
                            b.Color = colores[c];
                            c = c < colores.Length - 1 ? c + 1 : 0;
                            e.Graphics.FillRectangle(b, new RectangleF(x, y, propWGrafica, propHGrafica * (float)Valores[i]));
                        }
                       
                        x += propWGrafica * 2;
                    }                    
                }            
                else
                {
                    PointF p1;
                    PointF p2;
                    if (Valores[0] > maxY)
                    {
                        p1 = new PointF(x, this.Height - 2 * propH - maxY * propHGrafica);
                    }
                    else
                    {
                        p1 = new PointF(x, this.Height - 2 * propH - (float)Valores[0] * propHGrafica);
                    }                    
                    
                    for (int i = 1; i < maxX; i++)
                    {
                        x += propWGrafica * 2;
                        if (Valores[i] > maxY)
                        {
                            p2 = new PointF(x, this.Height - 2 * propH - maxY * propHGrafica);
                        }
                        else
                        {
                            p2 = new PointF(x, this.Height - 2 * propH - (float)Valores[i] * propHGrafica);
                        }                                                                        
                        e.Graphics.DrawLine(pLineas, p1, p2);
                        p1 = p2;
                    }                    
                }                
            }
        }
    }
}
