namespace Laba3.ClassLibrary
{
    public class ClassSquare
    {
        public double S(double r, double R, double l)
        {
            if (r <= 0 && R <= 0 && l <= 0)
            {
                Console.WriteLine("Введите правильные данные");
                return 0;
            }
            return Math.PI * (r + R) * l;
        }
    }
}