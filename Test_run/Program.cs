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

            new Reveal();
        }
    }
}