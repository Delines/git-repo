using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class PackmanImg
    {
        Image[] up = new Image[] {
            Properties.Resources.PacmenImg0_1,
            Properties.Resources.PacmenImg0_1l,
            Properties.Resources.PacmenImg0_1ll,
            Properties.Resources.PacmenImg0_1lll,
            Properties.Resources.PacmenImg0_1lV };

        Image[] down = new Image[] {
            Properties.Resources.PacmenImg01,
            Properties.Resources.PacmenImg01l,
            Properties.Resources.PacmenImg01ll,
            Properties.Resources.PacmenImg01lll,
            Properties.Resources.PacmenImg01lV };

        Image[] right = new Image[] {
            Properties.Resources.PacmenImg10,
            Properties.Resources.PacmenImg10l,
            Properties.Resources.PacmenImg10ll,
            Properties.Resources.PacmenImg10lll,
            Properties.Resources.PacmenImg10lV };

        Image[] left = new Image[] {
            Properties.Resources.PacmenImg_10,
            Properties.Resources.PacmenImg_10l,
            Properties.Resources.PacmenImg_10ll,
            Properties.Resources.PacmenImg_10lll,
            Properties.Resources.PacmenImg_10lV };

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
