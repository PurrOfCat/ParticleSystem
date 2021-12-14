﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();        
        public float GravitationX = 0;
        public float GravitationY = 1;        

        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                {
                    ResetParticle(particle);
                }
                else
                {
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
                {
                    var particle = new ParticleColorful();
                    particle.FromColor = Color.White;
                    particle.ToColor = Color.FromArgb(0, Color.Black);

                    ResetParticle(particle);
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.rand.Next(100);
            particle.X = MousePositionX;
            particle.Y = MousePositionY;

            var direction = (double)Particle.rand.Next(360);
            var speed = 1 + Particle.rand.Next(10);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.rand.Next(10);
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
    }

    public class TopEmitter : Emitter
    {
        public int Width;
        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle);
                        
            particle.X = Particle.rand.Next(Width);
            particle.Y = 0;

            particle.SpeedY = 1;
            particle.SpeedX = Particle.rand.Next(-2, 2);
        }
    }
}
