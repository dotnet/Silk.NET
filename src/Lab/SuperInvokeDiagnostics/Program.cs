using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;
using Silk.NET.OpenGLES;
using Ultz.SuperInvoke.AOT;
using Ultz.SuperInvoke.Emit;

namespace SuperInvokeDiagnostics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = new LibraryBuilder();
            builder.Add(BuilderOptions.GetDefault(typeof(GL)));
            File.WriteAllBytes("il.dll", builder.BuildBytes());
            Process.Start
            (
                @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools\ildasm.exe",
                "/out=\"il.il\" \"il.dll\""
            )?.WaitForExit();
        }
    }
}
