class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No command line arguments were passed.");
            Console.Write("here is the program name: ");
            Console.WriteLine(Environment.CommandLine);
            return 1;
        }
        else
        {
            int i = 0;
            foreach (string arg in args)
            {
                Console.WriteLine($"argument at index {i}: {arg}");
                i++;
            }
        }

        return 0;
    }
}