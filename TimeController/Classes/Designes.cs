using System.Drawing;

namespace TimeController
{
    public class Design
    {
        public Color color1;
        public Color color2;
        public Color color3;
    }

    public class Design1 : Design
    {
        public Design1()
        {
            color1 = Color.FromArgb(176, 190, 197); // grey
            color2 = Color.FromArgb(249, 170, 51);  // orange
            color3 = Color.FromArgb(74, 101, 114);  // darkgrey
        }
    }

    public class Design2 : Design
    {
        public Design2()
        {
            color1 = Color.FromArgb(254, 234, 230); // grey
            color2 = Color.FromArgb(254, 219, 208); // pink 
            color3 = Color.FromArgb(136, 88, 92);   // dark pink (68, 44, 46)
        }
    }

    public class Design3 : Design
    {
        public Design3()
        {
            color1 = Color.FromArgb(178, 235, 242); // cyan
            color2 = Color.FromArgb(66, 165, 245);  // blue
            color3 = Color.FromArgb(128, 203, 196); // green
        }
    }

    public enum DesignTypes
    {
        DESIGN1,
        DESIGN2,
        DESIGN3
    }

    public class DesignFactory
    {
        public static Design Create(DesignTypes type)
        {
            switch (type)
            {
                case DesignTypes.DESIGN1:
                    return new Design1();
                case DesignTypes.DESIGN2:
                    return new Design2();
                case DesignTypes.DESIGN3:
                    return new Design3();
                default:
                    return new Design1();
            }
        }
    }

    }
