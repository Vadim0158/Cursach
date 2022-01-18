using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Courses.Particle;

namespace Courses
{
    public class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        public int X;
        public int Y;
        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;
        public int ParticlesCount = 500;

        public Color ColorFrom;
        public Color ColorTo;

        public int ParticlesPerTick = 1;

        public int MousePositionX;
        public int MousePositionY;

        public float GravitationX = 0;
        public float GravitationY = 0.5f;

        public virtual void ResetParticle(Particle particle)
        {
            if (particle is ParticleColorful particleColor)
            {
                particleColor.FromColor = ColorFrom;
                particleColor.ToColor = ColorTo;
            }
            particle.Life = rand.Next(LifeMin, LifeMax);
           
            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)rand.Next(Spreading)
                - Spreading / 2;


            var speed = rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);            

            particle.Radius = rand.Next(RadiusMin, RadiusMax);
        }
        
        //метод обновления состояния системы
        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;

            foreach (var particle in particles.ToList())
            {

                if (particle.Life <= 0)
                {
                    if (particlesToCreate > 0)
                        particles.Remove(particle);
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    particle.Life--;
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate--;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful
            {
                FromColor = ColorFrom,
                ToColor = ColorTo
            };

            ResetParticle(particle);
            return particle;
        }

        public void Render(Graphics g)
        {
            foreach (var point in impactPoints.ToList())
            {
                point.Render(g);
            }

            foreach (var particle in particles.ToList())
            {
                particle.Draw(g);
            }
        }
    }
}
