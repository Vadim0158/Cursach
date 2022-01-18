using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Courses
{
    public class Particle
    {
        public int Radius; // радуис частицы
        public float X; // X координата положения частицы в пространстве
        public float Y;// Y координата положения частицы в пространстве

        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y

        public float Life;

        public static Random rand = new Random();

        public Particle()
        {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            // рассчитываем вектор скорости
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, MathF.Abs(Life / 100));
            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }

    public class ParticleColorful : Particle
    {
        public Color FromColor;
        public Color ToColor;

        public bool Cross = false;

        public static Bitmap cross = new(Properties.Resources.cross);

        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
            );
        }

        public override void Draw(Graphics g)
        {
            if (!Cross)
            {
                float k = Math.Min(1f, MathF.Abs(Life / 100));

                var color = MixColor(ToColor, FromColor, k);
                var b = new SolidBrush(color);

                g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

                b.Dispose();
            }
            else
            {
                Bitmap particle = new(cross, new Size(Radius * 2, Radius * 2));
                g.DrawImage(particle, new Point(Convert.ToInt32(X - Radius), Convert.ToInt32(Y - Radius)));
            }
        }
    }
}
