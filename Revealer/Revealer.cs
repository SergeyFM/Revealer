global using Revealer;
using System.Runtime.CompilerServices;

namespace Revealer {
    /// <summary>
    /// Reveals who called
    /// new Reveal();
    /// </summary>
    public class Reveal {
        public Reveal(string message = "",
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string sourceFilePath = "",
                [CallerLineNumber] int sourceLineNumber = 0) {
            string msg = message != "" ? $"\t{message}" : "";
            string file = sourceFilePath.Split(@"\").Last();

            //Console.WriteLine($"{memberName}() from {file} line {sourceLineNumber}" + msg);
            Console.WriteLine($"{file}:{sourceLineNumber} \t {memberName}()" + msg);
        }

    }
}
