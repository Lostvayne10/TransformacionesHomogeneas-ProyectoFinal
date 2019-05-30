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

        void animacionRotar(List<Point> l, string grados)
        {
            Point pcentro = GetCentro(l);
            translacionAnimada(l, (-pcentro.X).ToString(), (-pcentro.Y).ToString());
            List<Point> temp = Translacion(l,(-pcentro.X).ToString(),(-pcentro.Y).ToString());
            rotacionAnimada(temp, grados);
            temp = Rotacion(temp, grados);
            translacionAnimada(temp, (pcentro.X).ToString(), (pcentro.Y).ToString());
        }

        void animacionEscalar(List<Point> l, double Esc)
        {
            Point pcentro = GetCentro(l);
            translacionAnimada(l, (-pcentro.X).ToString(), (-pcentro.Y).ToString());
            List<Point> temp = Translacion(l, (-pcentro.X).ToString(), (-pcentro.Y).ToString());
            escaladoAnimada(temp, Esc);
            temp = Escalado(temp, Esc);
            translacionAnimada(temp, (pcentro.X).ToString(), (pcentro.Y).ToString());
        }

        void rotacionAnimada(List<Point> l, string grados)
        {
            for(int i=1;i<=Convert.ToInt32(grados);i++)
            {
                DibujarFigura(Rotacion(l,(i-1).ToString()),pincel(Color.White));
                DibujarFigura(Rotacion(l, (i).ToString()), pincel(Color.Black));
                System.Threading.Thread.Sleep(100);
            }
        }

        void escaladoAnimada(List<Point> l, double Esc )
        {
            double inc;
            inc = .10;
            if (Esc<1.00)
            {
               
                inc = -.10;
                for (double i = 1; i >= Esc; i = i + inc)
                {
                    dibujarrectblanco(GetPMenor(Escalado(l, i-inc)), GetPMayor(Escalado(l, i-inc)));
                    DibujarFigura(Escalado(l, i), pincel(Color.Black));
                    System.Threading.Thread.Sleep(100);

                }
            }
            else
            {
                for (double i = 1; i <= Esc; i = i + inc)
                {

                    dibujarrectblanco(GetPMenor(Escalado(l, i - inc)), GetPMayor(Escalado(l, i - inc)));
                    //DibujarFigura(Escalado(l, i - inc), pincel(Color.White));
                    DibujarFigura(Escalado(l, i), pincel(Color.Black));
                    System.Threading.Thread.Sleep(100);

                }
            }
           
        }

        void translacionAnimada(List<Point> l, string txs, string tys)
        {
            int incx, incy;
            incx = incy = 1;
            if(Convert.ToInt32(txs) < 0)
            {
                incx = -1;
            }
            if (Convert.ToInt32(tys) < 0)
            {
                incy = -1;
            }
            for (int i = 1; i != Convert.ToInt32(txs); i+=incx)
            {
                DibujarFigura(Translacion(l, (i - incx).ToString(), 0.ToString()), pincel(Color.White));
                DibujarFigura(Translacion(l, (i).ToString(), 0.ToString()),  pincel(Color.Black));
                System.Threading.Thread.Sleep(10);
            }
            for (int i = 1; i != Convert.ToInt32(tys); i+=incy)
            {
                DibujarFigura(Translacion(l,txs, (i - incy).ToString()), pincel(Color.White));
                DibujarFigura(Translacion(l,txs, (i).ToString()), pincel(Color.Black));
                System.Threading.Thread.Sleep(10);
            }
        }

        public List<Point> Rotacion(List<Point> l, string grados)
        {
            List<Point> pr = new List<Point>();
            double teta = Convert.ToSingle(grados);
            teta = (Math.PI * teta)/180;
            Point pcentro = GetCentro(l);
            Point temp;
            int xe, ye,tx,ty;
            
            for (int i=0;i<l.Count;i++)
            {
                temp = GetPointAng(l[i].X - pcentro.X, l[i].Y - pcentro.Y, teta);
                pr.Add(temp);
            }
            Point c2 = GetCentro(pr);
            tx = pcentro.X - c2.X;
            ty = pcentro.Y - c2.Y;
            pr = Translacion(pr, tx.ToString(), ty.ToString());


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
        public List<Point> Escalado(List<Point> l, double Esc)
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

        public Point GetPMenor(List<Point> l)
        {
            Point p;
            int xm, ym, xs, ys, xc, yc;
            xm = ym = 100000;
            ys = xs = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (xm > l[i].X)
                {
                    xm = l[i].X;
                }
                if (ym > l[i].Y)
                {
                    ym = l[i].Y;
                }
           
            }

            p = new Point(xm, ym);

            return p;
        }

        public Point GetPMayor(List<Point> l)
        {
            Point p;
            int xm, ym, xs, ys, xc, yc;
            xm = ym = 100000;
            ys = xs = 0;
            for (int i = 0; i < l.Count; i++)
            {
       
                if (xs < l[i].X)
                {
                    xs = l[i].X;
                }
                if (ys < l[i].Y)
                {
                    ys = l[i].Y;
                }
            }
 
            p = new Point(xs, ys);

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
                DibujarFigura(lp,pen1);
                panel1.CreateGraphics().DrawEllipse(pen1, GetCentro(lp).X, GetCentro(lp).Y, 1, 1);
                DibujarCentro(lp);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nump = Convert.ToInt32(comboBox1.Text);
            cont = 0;
            lp = new List<Point>();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            textBox1.Text = (((float)vScrollBar1.Value / (float)10)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            if (comboBox2.SelectedIndex == 0)
            {
                translacionAnimada(lp, translacionx.Text, translaciony.Text);
                //DibujarFigura(Translacion(lp, translacionx.Text,translaciony.Text),pen1);
                DibujarCentro(Translacion(lp, translacionx.Text, translaciony.Text));
            }
            if (comboBox2.SelectedIndex == 1)
            {
                animacionRotar(lp, cbxgrados.Text);
                //rotacionAnimada(lp, cbxgrados.Text);
                //DibujarFigura(Rotacion(lp, cbxgrados.Text), pen1);
                DibujarCentro(Rotacion(lp, cbxgrados.Text));
            }
            if (comboBox2.SelectedIndex==2)
            {
                animacionEscalar(lp, ((float)vScrollBar1.Value / (float)10));
                //escaladoAnimada(lp, ((float)vScrollBar1.Value / (float)10));
                //DibujarFigura(Escalado(lp, ((float)vScrollBar1.Value / (float)10)), pen1);
                DibujarCentro(Escalado(lp, ((float)vScrollBar1.Value / (float)10)));
            }
            if(comboBox2.SelectedIndex == 3)
            {
                DibujarFigura(ReflexionSobreX(lp), pen1);
                DibujarCentro(ReflexionSobreX(lp));
            }
            if (comboBox2.SelectedIndex == 4)
            {
                DibujarFigura(ReflexionSobreY(lp), pen1);
                DibujarCentro(ReflexionSobreY(lp));
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

        public void DibujarFigura(List<Point> l,Pen a)
        {
            Point[] Arr = new Point[l.Count+1];
            for (int i=0;i<lp.Count;i++)
            {
                Arr[i] = l[i];
            }
            Arr[l.Count] = l[0];
            panel1.CreateGraphics().DrawLines(a, Arr);
        }

        public void DibujarCentro(List<Point> l)
        {
            Point center = GetCentro(l);
            panel1.CreateGraphics().DrawLine(pincel(Color.Red), center.X - 5, center.Y, center.X + 5, center.Y);
            panel1.CreateGraphics().DrawLine(pincel(Color.Red), center.X , center.Y-5, center.X , center.Y+5);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        Pen pincel(Color a)
        {
            Pen pincel = new Pen(a, 1);
            return pincel;
        }

        public Point GetPointAng(int x, int y, double tetha)
        {
            Point e;
            double costeta,xp,yp;
            double senteta;
            costeta = Math.Cos(tetha);
            senteta = Math.Sin(tetha);
            xp = costeta * (float)x - senteta * (float)y;
            yp = senteta * (float)x + costeta * (float)y;
            e = new Point((int)xp,(int)yp);
            return e;
        }

        void dibujarrectblanco(Point a, Point b)
        {
            SolidBrush ba = new SolidBrush(Color.White);
            panel1.CreateGraphics().FillRectangle(ba, a.X, a.Y, b.X, b.Y);

        }
    }
}
