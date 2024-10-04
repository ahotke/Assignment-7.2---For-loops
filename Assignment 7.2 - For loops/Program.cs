namespace Assignment_7._2___For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, timesRepeated = 10;
            string name;

            //Blastoff
            for (int i = 10; i >= 1; i = i - 1)
                Console.WriteLine(i);

            Console.WriteLine("Blastoff!");
            Console.WriteLine();

            //X and Y
            Console.WriteLine("X" + '\t' + "Y");
            Console.WriteLine("--------------------");
            for (int i = -10; i >= 10; i = i + 2)
            {
                y = i * i;
                Console.WriteLine(i + '\t' + y);
            }
            Console.WriteLine();

            // Name repeater
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (name == "aldworth")
                timesRepeated = 5;

            for (int i = 0; i <= timesRepeated; i++);
                Console.WriteLine(name);

        }
    }
}
