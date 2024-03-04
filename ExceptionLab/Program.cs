namespace ExceptionLab
{
    class Circle
    {
        public double Radius { get; set; }
        public void SetRadius(double radius)
        {
            if(radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new InvalidRadiusException(radius);
            }
        }

        public void ToString()
        {
            Console.WriteLine("Circle: Radius is " + Radius);
        }
    }

    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        {
            Console.WriteLine("Radius is greater than zero");
        }
        
        public InvalidRadiusException(double radius)
        {
            Console.WriteLine(radius + " as a radius is invalid");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius of 1");
            Circle circle = new Circle();
            circle.SetRadius(1);
            try
            {
                Console.WriteLine("Radius of 0");
                Circle circle1 = new Circle();
                circle.SetRadius(0);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("Exception Thrown");
            }
            try
            {
                Console.WriteLine("Radius of -1");
                Circle circle2 = new Circle();
                circle.SetRadius(-1);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("Exception Thrown");
            }
        }
    }
}
