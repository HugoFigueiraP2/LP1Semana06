using System;
using System.Drawing;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;
        private Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public static Color ShowColor(byte red, byte green, byte blue, byte alpha)
        {
            return new Color(red, green, blue, alpha);
        }

        private byte Red_method
        {
            get {return red;}
            set {red = value;}
        }

        private byte Blue_method
        {
            get {return blue;}
            set {blue = value;}
        }

        private byte Green_method
        {
            get {return green;}
            set {green = value;}
        }

        private byte SetGrey
        {
            set {red = green = blue = value;}
        }

        private byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);

        }


        
    }
}
