using Revealer;

namespace Test_run {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            new Reveal();
            new Reveal("Some random message", true);

            for(int i = 0; i < 10; i++) {
                new Reveal();
            }

            new Reveal(); // Revealer will only show the repeating message after the different call comes. Otherwise he doesn't know that the last call was the last one.
        }
    }
}