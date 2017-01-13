using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Packman: IRun, ITurn, ITransparent
    {
        PackmanImg packmanImg = new PackmanImg();
        Image[] img;
        Image curentImg;

        public Image CurentImg
        {
            get { return curentImg; }
        }

        int sizeField;
        int x, y, direct_x, direct_y;
        static Random r;

        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_x = value;
                else direct_x = 0;
            }
        }

        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1)
                    direct_y = value;
                else direct_y = 0;
            }
        }

        public Packman(int sizeField) 
        {
            this.sizeField = sizeField;                       

            PutImg();

            PutCurentImg();

            this.x = 120;
            this.y = 220;
        }

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public void Run()
        {
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn();
            PutCurentImg();

            Transparent();
        }

        int k;

        private void PutCurentImg()
        {
            curentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }

        public void Turn()
        {
            //!!!!!          

            PutImg();
        }

        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 20 + 1)
                x = 1;

            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }

        void PutImg()
        {
            if (direct_x == 1)
                img = packmanImg.Right;
            if (direct_x == -1)
                img = packmanImg.Left;
            if (direct_y == 1)
                img = packmanImg.Down;
            if (direct_y == -1)
                img = packmanImg.Up;
        }

    }
}
