namespace Laba3.ClassLibrary
{
    public class ClassSquare
    {
        public double S(double r, double R, double l)
        {
            if (r <= 0 || R <= 0 || l <= 0)
            {
                throw new ArgumentException("Arguments cannot be negative");
            }
            return Math.PI * (r + R) * l;
        }
    }
}