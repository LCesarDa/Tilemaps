using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tilemaps
{
    public partial class Form1 : Form
    {
        Bitmap ima1;
        public Form1()
        {
            InitializeComponent();

            ima1 = new Bitmap(250, 250);
            DrawMap(Class1.map0);
            pictureBox1.Image = ima1;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrawMap(byte[,] map0)
        {
            Graphics g = Graphics.FromImage(ima1);
            g.Clear(Color.Black);

            for (int x = 0; x < map0.GetLength(0); x++)
            {
                for (int y = 0; y < map0.GetLength(1); y++)
                {
                    if (map0[y,x] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 10, y * 10, 10, 10);
                    }
                    if (map0[y, x] == 0)
                    {
                        g.DrawRectangle(Pens.Gray, x*10, y*10, 10, 10);
                    }
                    if (map0[y, x] == 8)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), x * 10, y * 10, 10, 10);
                    }
                }
            }

            //Util.Instance.HitWall(player, lookAt);
            //g.DrawRectangle(Pens.Gray, 0, 0, 249, 249);
            //g.FillEllipse(Brushes.Red, Player.x - 3, Player.y - 3, 249, 249);
            //g.DrawLine(Pens.Yellow, player, lookAt);
            //g.DrawLine(Pens.Green, player, collision);

            //pictureBox2.Image = ima1;

        }
    }
}
