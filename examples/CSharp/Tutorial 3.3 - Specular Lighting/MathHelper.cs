using System;

namespace Tutorial
{
    public static class MathHelper
    {
        public static float DegreesToRadians(double degrees)
        {
            return (float)(Math.PI / 180f * degrees);
        }
    }
}