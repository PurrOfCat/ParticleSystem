using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        CounterPoint point1;
        //GravityPoint point2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            this.emitter = new Emitter
            {
                Direction = 90,
                Spreading = 180,
                SpeedMin = 13,
                SpeedMax = 13,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 30,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };             

            emitters.Add(this.emitter);
                        
            /*point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };
            
            emitter.impactPoints.Add(point2);*/

            point1 = new CounterPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            emitter.impactPoints.Add(point1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            picDisplay.Invalidate();
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            point1.X = e.X;
            point1.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
           /*point1.Power = tbGraviton.Value;*/
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            /*point2.Power = tbGraviton2.Value;*/
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                point1.Power += 10;
            } 
            else if (point1.Power != 0)
            {
                point1.Power -= 10;
            } 
        }
    }
}
