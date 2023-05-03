global using Revealer;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Revealer {
    /// <summary>
    /// Reveals who has called it.
    /// Insert "new Reveal();" anywhere. Used for debugging and research.
    /// </summary>

    public class Reveal {
        public Reveal(string message = "", bool VIP = false,
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string sourceFilePath = "",
                [CallerLineNumber] int sourceLineNumber = 0) {
            string msg = message != "" ? $"\t{message}" : "";
            string file = sourceFilePath.Split(@"\").Last();

            string file_lineN = $"{file}:{sourceLineNumber} \t {memberName}()";
            if (_last_file_lineN != file_lineN) {

                if (_last_file_lineN_Count > 0) 
                    Console.WriteLine($"* {_last_file_lineN} was called {_last_file_lineN_Count} times more]");
                
                if (VIP) Console.Write(">>>>>>>>>>>> "); // mark very important positions with a easy-to-notice line
                
                Console.WriteLine($"{file}:{sourceLineNumber} \t {memberName}()" + msg);

                _last_file_lineN = file_lineN;
                _last_file_lineN_Count = 0;

            } else {
                _last_file_lineN_Count++; // don't show anything when the call is the same
            }
        }

        public static string _last_file_lineN = "";
        public static int _last_file_lineN_Count = 0;


    }
}
