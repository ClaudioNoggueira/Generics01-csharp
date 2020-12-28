using System;

namespace Generics01 {
    class Program {
        static void Main(string[] args) {
            PrintService<string> print = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string x = Console.ReadLine();
                print.AddValue(x);
            }

            print.Print();
            Console.WriteLine("First: " + print.First());
        }
    }
}
