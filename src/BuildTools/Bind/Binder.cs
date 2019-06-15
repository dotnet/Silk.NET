using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;
using Generator.Bind.Overloading;
using Generator.Common;
using Newtonsoft.Json;

namespace Generator.Bind
{
    /// <summary>
    /// The entry point for the bindings writer.
    /// </summary>
    public class Binder
    {
        /// <summary>
        /// Gets or sets the parsed command-line options.
        /// </summary>
        public static BindOptions CliOptions { get; set; }

        /// <summary>
        /// The entry point for the bindings writer.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Bind(BindOptions args)
        {
            CliOptions = args;
            Task.WhenAll
            (
                CliOptions.InputFiles.Select(File.ReadAllText)
                    .Select(JsonConvert.DeserializeObject<Profile>)
                    .Select(x => x.FlushAsync())
            )
            .GetAwaiter()
            .GetResult();
        }
    }
}
