using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Revealer {
    /// <summary>
    /// Reveals who called
    /// new Revealer();
    /// </summary>
    public class Revealer {
        public Revealer(string message = "",
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string sourceFilePath = "",
                [CallerLineNumber] int sourceLineNumber = 0) {
            string msg = message != "" ? $" msg: {message}" : "";
            
            Console.WriteLine($"{memberName}() from {sourceFilePath} line {sourceLineNumber}" + msg);
        }

    }
}
