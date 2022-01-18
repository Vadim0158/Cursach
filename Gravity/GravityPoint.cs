using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Courses
{
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                // то притягиваем ее                
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;                                
            }
        }

        public override bool Overlaps(Particle particle)
        {
            throw new NotImplementedException();
        }

        public override void Render(Graphics g)
        {
            /*
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Blue),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );

            var stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center; 
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(
           $"{Power}", 
           new Font("Comic Sans MS", 10), // шрифт и его размер
           new SolidBrush(Color.White), // цвет шрифта
           X, // расположение в пространстве
           Y,
           stringFormat);*/
        }
    }
}
