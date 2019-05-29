using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformacionesBasicas
{
    public partial class Form1 : Form
    {
        Pen pen1 = new Pen(Color.Black, 1);
        List<Point> lp = new List<Point>();
        int cont,nump;

        public Form1()
        {
            InitializeComponent();
            cont = 0;
            nump = 4;
        }

        public List<Point> Rotacion(List<Point> l, string grados)
        {
            List<Point> pr = new List<Point>();
            double teta = Convert.ToSingle(grados);
            Point pcentro = GetCentro(l);
            Point temp;
            int xe, ye,tx,ty;
            MessageBox.Show(teta.ToString());
            for (int i=0;i<l.Count;i++)
            {
                xe = (int)((l[i].X - pcentro.X) *(Math.Cos(teta) ) + ((l[i].Y - pcentro.Y) *-Math.Sin(teta)))+ pcentro.X;
                ye = (int)((l[i].X - pcentro.X) *(Math.Sin(teta) ) + ((l[i].Y - pcentro.Y) * Math.Cos(teta)))+ pcentro.Y;
                temp = new Point(xe, ye);
                pr.Add(temp);
               
            }
            /*Point pc = GetCentro(pr);
            tx = pcentro.X - pc.X;
            ty = pcentro.Y - pc.Y;
            pr = Translacion(pr, Convert.ToString(tx), Convert.ToString(ty));*/

            return pr;
        }
        public List<Point> Translacion(List<Point> l, string txs, string tys)
        {
            List<Point> pr = new List<Point>();
            Point temp;
            int  xe, ye,tx,ty;
            tx = Convert.ToInt32(txs);
            ty = Convert.ToInt32(tys);
            xe = ye = 0;
    
            for (int i = 0; i < l.Count; i++)
            {
                xe = (l[i].X + tx);
                ye = (l[i].Y + ty);
                temp = new Point(xe, ye);
                pr.Add(temp);

            }

            return pr;
        }
        public List<Point> Escalado(List<Point> l, float Esc)
        {
            List<Point> pr = new List<Point>();
            Point temp;
            int xc,yc,xe,ye;
            xe = ye = 0;
            xc = GetCentro(l).X;
            yc = GetCentro(l).Y;
            for(int i=0;i<l.Count;i++)
            {
                xe = (int)Math.Round((l[i].X - xc) * Esc) + xc;
                ye = (int)Math.Round((l[i].Y - yc) * Esc) + yc;
                temp = new Point(xe, ye);
                pr.Add(temp);

            }

            return pr;
        }
        public List<Point> ReflexionSobreX(List<Point> l)
        {
            List<Point> pr = new List<Point>();
            Point temp;
            Point pcentro = GetCentro(l);
            int  xe, ye;
            xe = ye = 0;
            for (int i=0;i<l.Count;i++)
            {
                xe = l[i].X;
                ye = ((pcentro.Y - l[i].Y) * 2)+ l[i].Y;
                temp = new Point(xe,ye);
                pr.Add(temp);
            }

            return pr;
        }
        public List<Point> ReflexionSobreY(List<Point> l)
        {
            List<Point> pr = new List<Point>();
            Point temp;
            Point pcentro = GetCentro(l);
            int xe, ye;
            xe = ye = 0;
            for (int i = 0; i < l.Count; i++)
            {
                ye = l[i].Y;
                xe = ((pcentro.X - l[i].X) * 2) + l[i].X;
                temp = new Point(xe, ye);
                pr.Add(temp);
            }

            return pr;
        }

        public Point GetCentro(List<Point> l)
        {
            Point p ;
            int xm, ym, xs, ys,xc,yc;
            xm = ym = 100000;
            ys = xs = 0 ;
            for (int i=0;i<l.Count;i++)
            {
                if(xm>l[i].X)
                {
                    xm = l[i].X;
                }
                if (ym > l[i].Y)
                {
                    ym = l[i].Y;
                }
                if (xs < l[i].X)
                {
                    xs = l[i].X;
                }
                if (ys < l[i].Y)
                {
                    ys = l[i].Y;
                }
            }
            xc = ((xs - xm) / 2) + xm;
            yc = ((ys - ym) / 2) + ym;
            p = new Point(xc, yc);

            return p;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Point p = new Point(e.X, e.Y);
            if(cont< nump)
            {
                panel1.CreateGraphics().DrawEllipse(pen1, e.X, e.Y, 1, 1);
                lp.Add(p);
                cont++;
            }
            if(cont== nump)
            {
                DibujarFigura(lp);
                panel1.CreateGraphics().DrawEllipse(pen1, GetCentro(lp).X, GetCentro(lp).Y, 1, 1);
                DibujarCentro(lp);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nump = Convert.ToInt32(comboBox1.Text);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            textBox1.Text = (vScrollBar1.Value / 10).ToString();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            if (comboBox2.SelectedIndex == 0)
            {
                DibujarFigura(Translacion(lp, translacionx.Text,translaciony.Text));
                DibujarCentro(lp);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                DibujarFigura(Rotacion(lp, cbxgrados.Text));
                DibujarCentro(Rotacion(lp, cbxgrados.Text));
            }
            if (comboBox2.SelectedIndex==2)
            {
                DibujarFigura(Escalado(lp, (float)(vScrollBar1.Value / 10)));
                DibujarCentro(lp);
            }
            if(comboBox2.SelectedIndex == 3)
            {
                DibujarFigura(ReflexionSobreX(lp));
                DibujarCentro(lp);
            }
            if (comboBox2.SelectedIndex == 4)
            {
                DibujarFigura(ReflexionSobreY(lp));
                DibujarCentro(lp);
            }
        }

        private void translacionx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void translaciony_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void translacionx_MouseClick(object sender, MouseEventArgs e)
        {
            translacionx.Text = "";
        }

        private void translaciony_MouseClick(object sender, MouseEventArgs e)
        {
            translaciony.Text = "";
        }

        public void DibujarFigura(List<Point> l)
        {
            Point[] Arr = new Point[l.Count+1];
            for (int i=0;i<lp.Count;i++)
            {
                Arr[i] = l[i];
            }
            Arr[l.Count] = l[0];
            panel1.CreateGraphics().DrawLines(pen1, Arr);
        }

        public void DibujarCentro(List<Point> l)
        {
            Point center = GetCentro(l);
            panel1.CreateGraphics().DrawLine(pincel(Color.Red), center.X - 15, center.Y, center.X + 15, center.Y);
            panel1.CreateGraphics().DrawLine(pincel(Color.Red), center.X , center.Y-15, center.X , center.Y+15);

        }

        Pen pincel(Color a)
        {
            Pen pincel = new Pen(a, 1);
            return pincel;
        }
    }
}
