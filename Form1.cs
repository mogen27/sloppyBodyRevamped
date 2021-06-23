using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sloppyBody
{
    public partial class Form1 : Form
    {

        //public List<massPoint> block = new List<massPoint>();

        public massPoint[,] block;

        public void fillBlock(vector midPos, int count, double spacing, double mass)
        {
            block = new massPoint[Convert.ToInt32(count), Convert.ToInt32(count)];
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    
                    block[i,j] = new massPoint(new vector(midPos.x + j * spacing, midPos.y + i * spacing), new vector(0, 0), 1);

                    //adding neighboors(naybers)
                    block[i, j].naybersIndex.Add(new vector(i - 1, j - 1));
                    block[i, j].naybersIndex.Add(new vector(i - 1, j + 1));
                    block[i, j].naybersIndex.Add(new vector(i - 1, j));

                    block[i, j].naybersIndex.Add(new vector(i, j - 1));
                    block[i, j].naybersIndex.Add(new vector(i, j + 1));


                    block[i, j].naybersIndex.Add(new vector(i + 1, j));
                    block[i, j].naybersIndex.Add(new vector(i + 1, j - 1));
                    block[i, j].naybersIndex.Add(new vector(i + 1, j + 1));

                    block[i, j].fixList(count);

                    //block.Add(new massPoint(new vector(midPos.x + j * spacing, midPos.y + i * spacing), new vector(0, 0), 1));

                    //block[i, j].naybers.Add(new vector(i - 1, j - 1));

                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillBlock(new vector(500,300), 15, 20, 1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush massPointColor = new SolidBrush(Color.Red);
            Pen springColor = new Pen(Color.Black);

            for(int i = 0; i < Math.Sqrt(block.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(block.Length); j++)
                {
                    g.FillEllipse(massPointColor, new RectangleF((float)block[i,j].pos.x, (float)block[i,j].pos.y, 3, 3));
                    //Ritar upp linjer mellan alla boysen! Kom ihåg att eventuell omptimiseringsväg är att inte rita upp dubblade linjer (från a till b samt b till a)
                    for(int k = 0; k < block[i, j].naybersIndex.Count; k++)
                    {
                        g.DrawLine(springColor, (float)block[i, j].pos.x, (float)block[i, j].pos.y,

                            (float)block[Convert.ToInt32(block[i, j].naybersIndex[k].x), 
                                         Convert.ToInt32(block[i, j].naybersIndex[k].y)].pos.x,
                            (float)block[Convert.ToInt32(block[i, j].naybersIndex[k].x), 
                                         Convert.ToInt32(block[i, j].naybersIndex[k].y)].pos.y);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            //time 2 beräkna kraften från varje liten springilingflingading
            for (int i = 0; i < Math.Sqrt(block.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(block.Length); j++)
                {
                    for(int k = 0; k < block[i,j].naybersIndex.Count; k++)
                    {

                         //   block[i, j].force = vector.add(block[i, j].force, 
                         //   new vector(vector.multNum(vector.normalize(vector.sub()))))
                    }
                }
            }
            Refresh();
        }
    }
}
