using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Window;
using SFML.Graphics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Test01");
            window.Closed += (object sender, EventArgs e) => { (sender as Window).Close(); };


            Font font = new Font("SnowflakeLetters.ttf");           
            Text text = new Text("BALD IST WEIHNACHTEN!", font);    
            Color col1 = new Color(123, 12, 12);
            text.Position = new Vector2f(200, 200);
            CircleShape shape = new CircleShape(20, 8);
            shape.FillColor = Color.White;
            shape.Position = new Vector2f(50, 50);
            float a, c;
            a = c = 50f;

            while (window.IsOpen())
            {
                window.Clear(col1);
                window.Draw(text);
                if (Keyboard.IsKeyPressed(Keyboard.Key.Left) && a > 0)
                    a -= 0.1f;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Right) && a < window.Size.X - shape.Radius * 2)
                    a += 0.1f;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && c < window.Size.Y - shape.Radius * 2)
                    c += 0.1f;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && c >  0)
                    c -= 0.1f;
                window.Draw(shape);
                shape.Position = new Vector2f(a, c);

                window.Display();
                window.DispatchEvents();
            }
        }
    }
}
