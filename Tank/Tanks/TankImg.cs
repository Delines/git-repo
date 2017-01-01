using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class TankImg
    {
        Image [] up = new Image [] {
            Properties.Resources.TankImg0_1,
            Properties.Resources.TankImg0_1l,
            Properties.Resources.TankImg0_1ll,
            Properties.Resources.TankImg0_1lll,
            Properties.Resources.TankImg0_1lV };

        Image[] down = new Image[] {
            Properties.Resources.TankImg01,
            Properties.Resources.TankImg01l,
            Properties.Resources.TankImg01ll,
            Properties.Resources.TankImg01lll,
            Properties.Resources.TankImg01lV };

        Image[] right = new Image[] {
            Properties.Resources.TankImg10,
            Properties.Resources.TankImg10l,
            Properties.Resources.TankImg10ll,
            Properties.Resources.TankImg10lll,
            Properties.Resources.TankImg10lV };

        Image[] left = new Image[] {
            Properties.Resources.TankImg_10,
            Properties.Resources.TankImg_10l,
            Properties.Resources.TankImg_10ll,
            Properties.Resources.TankImg_10lll,
            Properties.Resources.TankImg_10lV };

        public Image[] Up
        {
            get { return up; }
        }

        public Image[] Down
        {
            get { return down; }
        }

        public Image[] Right
        {
            get { return right; }
        }

        public Image[] Left
        {
            get { return left; }
        }

          
    }
}
