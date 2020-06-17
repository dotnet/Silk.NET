// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Bind
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
            Console.WriteLine("Loading profiles...");
            //CliOptions.InputFiles.Select(File.ReadAllText)
            //    .Select(JsonConvert.DeserializeObject<Profile>)
            //    .ForEach(x => x.Flush());
        }
    }
}
