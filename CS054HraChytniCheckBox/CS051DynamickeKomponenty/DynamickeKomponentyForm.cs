using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS051DynamickeKomponenty
{
    public partial class DynamickeKomponentyForm : Form
    {
        public DynamickeKomponentyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DynamickeKomponentyForm_Click(object sender, EventArgs e)
        {
            
        }

        private class AnimovanyObjekt
        {
            public int dx { get; set; }
            public int dy { get; set; }

            public AnimovanyObjekt(int dx, int dy)
            {
                this.dx = dx;
                this.dy = dy;
            }
        }

        private Random rnd = new Random();


        private void DynamickeKomponentyForm_MouseClick(object sender, MouseEventArgs e)
        {
            var checkbox = new CheckBox()
            {
                Top = e.Y,
                Left = e.X,
                Tag = new AnimovanyObjekt(rnd.Next(1, 5), rnd.Next(1, 5)),
            };
            checkbox.CheckedChanged += animovanyCheckBox_CheckedChanged;
            this.Controls.Add(checkbox);

        }

        private void animaceTimer_Tick(object sender, EventArgs e)
        {
            int height = this.Height -60;
            int width = this.Width -40;
            int aoX, aoY;

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    CheckBox ch = (c as CheckBox);

                    AnimovanyObjekt ao = (ch.Tag as AnimovanyObjekt);
                    
                    ch.Top += ao.dy;
                    ch.Left += ao.dx;
                    aoX = ch.Top;
                    aoY = ch.Left;

                    if (aoX >= (height) || aoX <= 10)
                    {
                        ao.dy *= -1;
                    }
                    if (aoY >= (width) || aoY <= 10)
                    {
                        ao.dx *= -1;
                    }
                }                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
        private int score = 0;
        private void animovanyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            scoreLabel.Text = string.Format("score:{0:00000}" ,score++);
        }
    }
}
