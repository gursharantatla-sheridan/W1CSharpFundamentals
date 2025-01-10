namespace W1CSharpFundamentals
{
    internal class Program
    {
        static int x;

        static void Main(string[] args)
        {
            int @float;
            int y;

            int i = 454;
            double d = 45.45;
            float f = 34.4F;
            decimal m = 5.5M;

            long l = 4543564L;

            var a = "5.5";

            Console.WriteLine(@"Hello\nworld");
            Console.WriteLine("\n\n");


            string[] colors = { "Red", "Blue", "Green", "Brown" };

            foreach (var c in colors)
                Console.WriteLine($"{c,-10}");
            Console.WriteLine("\n\n");



            int p = 5;
            int q = p;

            p = 10;


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            //Circle c2 = new Circle();
            c2.radius = 30;
            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);


            string s1 = "hello";
            string s2 = s1;

            s1 = "bye";

            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);

            Console.WriteLine("\n\n");



            double amount = 65745.324;
            Console.WriteLine("Amount = " + amount.ToString("C"));

            double rate = 0.15;
            Console.WriteLine("Rate = " + rate.ToString("P0"));

            double num = 76865454.3436;
            Console.WriteLine("Num = " + num.ToString("F3"));


            int? z = null;
            Console.WriteLine(z);

            i = (int)d;
        }
    }

    class Circle
    {
        public double radius;
    }
}
