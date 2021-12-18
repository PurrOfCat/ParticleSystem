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
        CounterPoint pointCounter;
        RepaintingPoint pointRed;
        RepaintingPoint pointOrange;
        RepaintingPoint pointYellow;
        RepaintingPoint pointGreen;        
        RepaintingPoint pointBlue;
        RepaintingPoint pointNavyBlue;
        RepaintingPoint pointPurple;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.MouseWheel += picDisplay_MouseWheel;
            
            pointRed = new RepaintingPoint
            {
                X = picDisplay.Width / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.Red
            };

            pointOrange = new RepaintingPoint
            {
                X = picDisplay.Width * 2 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.Orange
            };

            pointYellow = new RepaintingPoint
            {
                X = picDisplay.Width * 3 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.Yellow
            };

            pointGreen = new RepaintingPoint
            {
                X = picDisplay.Width * 4 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.LawnGreen
            };

            pointBlue = new RepaintingPoint
            {
                X = picDisplay.Width * 5 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.Cyan
            };

            pointNavyBlue = new RepaintingPoint
            {
                X = picDisplay.Width * 6 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.MediumBlue
            };

            pointPurple = new RepaintingPoint
            {
                X = picDisplay.Width * 7 / 8,
                Y = picDisplay.Height * 2 / 3,
                RepaintTo = Color.BlueViolet
            };

            pointCounter = new CounterPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            this.emitter = new Emitter
            {
                Direction = 90,
                Spreading = 100,
                SpeedMin = 12,
                SpeedMax = 12,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Black),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height * 2 / 7,
                Counter = pointCounter
            };

            emitters.Add(this.emitter);           
                                  
            emitter.impactPoints.Add(pointRed);
            emitter.impactPoints.Add(pointOrange);
            emitter.impactPoints.Add(pointYellow);
            emitter.impactPoints.Add(pointGreen);
            emitter.impactPoints.Add(pointBlue);
            emitter.impactPoints.Add(pointNavyBlue);
            emitter.impactPoints.Add(pointPurple);
            emitter.impactPoints.Add(pointCounter);
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

            pointCounter.X = e.X;
            pointCounter.Y = e.Y;
            pointCounter.Counter = 0;
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                pointCounter.Diametr += 10;
            }
            else if (pointCounter.Diametr != 0)
            {
                pointCounter.Diametr -= 10;
            }
        }

        private void tbMove_Scroll(object sender, EventArgs e)
        {
            pointRed.Y = tbMove.Value;
            pointOrange.Y = tbMove.Value;
            pointYellow.Y = tbMove.Value;
            pointGreen.Y = tbMove.Value;
            pointBlue.Y = tbMove.Value;
            pointNavyBlue.Y = tbMove.Value;
            pointPurple.Y = tbMove.Value;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;            
        }       

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
        }
    }
}
