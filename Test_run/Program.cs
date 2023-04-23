using Revealer;

namespace Test_run {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            new Reveal();
            new Reveal("Some random message");
        }
    }
}