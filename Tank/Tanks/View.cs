using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;

        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }

        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawApple(e);
            DrawTank(e);
            

            if (model.gamestatus != GameStatus.playing)
                return;
            
            Thread.Sleep(model.speedGame);
            Invalidate();
        }

        private void DrawApple(PaintEventArgs e)
        {
            foreach(Apple a in model.Apples)
                e.Graphics.DrawImage(a.Img, new Point (a.X, a.Y));
        }

        private void DrawTank(PaintEventArgs e)
        {
            foreach(Tank t in model.Tanks)
                e.Graphics.DrawImage(t.CurentImg, new Point(t.X, t.Y));
        }

        private void DrawWall(PaintEventArgs e)
        {
            for (int y = 20; y < 260; y += 40)
                for (int x = 20; x < 260; x += 40)
             e.Graphics.DrawImage(model.wall.Img, new Point(x, y));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }

       
    }
}
