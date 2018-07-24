using System;
namespace Checky
{
    public static class Helpers
    {



        public static NGraphics.Color ToNColor(this Xamarin.Forms.Color color) => new NGraphics.Color(color.R, color.G, color.B, color.A);

        public static double PerctPoint(this double total,double percentage) => (percentage / 100d) * total;


    }
}
