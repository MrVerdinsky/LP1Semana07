using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball01 = new Ball(new Color(255, 0, 0), 10);
            Ball ball02 = new Ball(new Color(0, 255, 0), 5);
            Ball ball03 = new Ball(new Color(0, 0, 255), 20);

            ball01.Throw();
            ball01.Throw();
            ball01.Throw();

            ball02.Throw();
            ball02.Throw();

            ball03.Throw();
            ball03.Throw();
            ball03.Pop();
            ball03.Throw();
            ball03.Throw();

            Console.WriteLine($"ball01 R Value:{ball01.Color.Red}");
            Console.WriteLine($"ball01 G Value:{ball01.Color.Green}");
            Console.WriteLine($"ball01 B Value:{ball01.Color.Blue}");
            Console.WriteLine($"ball01 Times Thrown:{ball01.NThrown}");

            Console.WriteLine();

            Console.WriteLine($"ball02 R Value:{ball02.Color.Red}");
            Console.WriteLine($"ball02 G Value:{ball02.Color.Green}");
            Console.WriteLine($"ball02 B Value:{ball02.Color.Blue}");
            Console.WriteLine($"ball02 Times Thrown:{ball02.NThrown}");

            Console.WriteLine();

            Console.WriteLine($"ball03 R Value:{ball03.Color.Red}");
            Console.WriteLine($"ball03 G Value:{ball03.Color.Green}");
            Console.WriteLine($"ball03 B Value:{ball03.Color.Blue}");
            Console.WriteLine($"ball03 Times Thrown:{ball03.NThrown}");

        }
    }
}
