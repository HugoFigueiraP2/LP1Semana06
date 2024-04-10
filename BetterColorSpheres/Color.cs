using System;
using System.Drawing;

namespace ColorSpheres
{
    public class Color
    {
        private  byte red;
        private  byte green;
        private  byte blue;
        private  byte alpha;
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

        

        public byte Red {get; set;}
        

        public byte Blue{get; set;}

        public byte Green{get; set;}

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
