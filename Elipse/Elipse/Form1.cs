using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Elipse
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen lapiz;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            SoundPlayer sonido = new SoundPlayer(@"C:\Users\Claudio Ivan\Music\L1\mix\8-bits\03_-_Xycle.wav");
            sonido.Play();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {try
            {
                double radioA = double.Parse(textBox1.Text);
                double radioB = double.Parse(textBox2.Text);
                dibujarElipse(radioA, radioB);
            }
            catch (Exception ex) { }
                       
        }

        void dibujarElipse(double radioA, double radioB)
        {
            g.Clear(Color.White);
            lapiz = new Pen(Color.FromArgb(0, 0, 0), 1);

            double a = (2 * Math.PI) / 720;

            List<Point> lista = new List<Point>();
            for (int i = 0; i < 720; i++)
            {
                int x =(int) ( (this.Width / 2) + (radioA * Math.Cos(a * i)) );
                int y = (int)((this.Height / 2) + (radioB * Math.Sin(a * i)));
                lista.Add(new Point(x, y));

            }

            for (int i = 1; i < lista.Count; i++)
            {
                g.DrawLine(lapiz, lista[i], lista[i - 1]);
            }

         //   lapiz.Color = Color.Green;
         //   g.DrawEllipse(lapiz,(this.Width / 2), (this.Height / 2),(float)(radioA*2),(float)(radioB*2));
      
        }
    }
}
