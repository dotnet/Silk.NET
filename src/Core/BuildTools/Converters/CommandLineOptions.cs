// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using CommandLine;

namespace Silk.NET.BuildTools.Converters
{
    /// <summary>
    /// The command-line options.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CommandLineOptions
    {
        /// <summary>
        /// Gets or sets the prefix to remove from parsed functions and constants.
        /// </summary>
        [Option
        (
            'p',
            "prefix",
            HelpText = "The prefix to remove from parsed functions and constants.",
            Default = "gl"
        )]
        public string Prefix { get; set; } = "gl";

        /// <summary>
        /// The reader/parser to use.
        /// </summary>
        [Option
        (
            'r',
            "reader",
            HelpText = "The reader/parser to use.",
            Required = true
        )]
        public string Reader { get; set; }

        /// <summary>
        /// The constructor/sorter to use.
        /// </summary>
        [Option
        (
            'c',
            "constructor",
            HelpText = "The constructor/sorter to use.",
            Required = true
        )]
        public string Constructor { get; set; }

        /// <summary>
        /// Gets or sets the path to the output file. Defaults to stdout if no path is provided.
        /// </summary>
        [Option
        (
            'o',
            "output-folder",
            HelpText = "The folder that the profiles should be written to.",
            Required = true
        )]
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets a list of the Khronos XML files to parse into Silk.NET XML. Remote resources in the form of URLs are
        /// supported.
        /// </summary>
        [Option
        (
            'i',
            "input-files",
            HelpText = "A list of the Khronos XML files to parse into Silk.NET XML. HTTP(S) URLs supported.",
            Required = true
        )]
        public IEnumerable<string> InputFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output files should be pretty printed.
        /// </summary>
        [Option
        (
            'f',
            "pretty",
            HelpText = "Indicates that the output files should be pretty printed.",
            Default = false
        )]
        public bool PrettyPrinted { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the transformed (interchange) XML should also be output.
        /// </summary>
        [Option
        (
            'x',
            "preserve-xml",
            HelpText = "Indicates whether the transformed (interchange) XML should also be output.",
            Default = false
        )]
        public bool IncludeXML { get; set; } = false;

        /// <summary>
        /// Gets or sets the paths of the typemaps to be used.
        /// </summary>
        [Option('t', "typemaps", HelpText = "The paths of the typemaps to use.", Required = false)]
        public IEnumerable<string> Typemap { get; set; }
    }
}
