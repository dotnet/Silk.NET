// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CommandLine;

// nullable stays disabled since else the compiler produces warnings cause we don't initialize the variables.
// all of the properties are required, therefore all of them will be not-null anyways.
// marked them with the attribute.

// !! TAKE CARE IF ADDING ADDITIONAL ARGUMENTS !!
#nullable disable

namespace Silk.NET.BuildTools.Bind
{
    /// <summary>
    /// Holds command-line arguments, parsed from the command line.
    /// </summary>
    public sealed class BindOptions
    {
        /// <summary>
        /// Gets or sets the base input path where the binder looks for specification files.
        /// </summary>
        [Option
        (
            'i',
            "input-files",
            HelpText = "The input files to write.",
            Required = true
        )]
        [NotNull]
        public IEnumerable<string> InputFiles { get; set; }

        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [Option
        (
            'o',
            "output-path",
            HelpText = "The base output path where the binder will write the generated files.",
            Required = true
        )]
        [NotNull]
        public string OutputPath { get; set; }

        /// <summary>
        /// Gets or sets the path to the license header.
        /// </summary>
        [Option
        (
            'l',
            "license",
            HelpText = "The path to the license header.",
            Required = true
        )]
        [NotNull]
        public string License { get; set; }

        /// <summary>
        /// Gets or sets the path to the binding's props file.
        /// </summary>
        [Option
        (
            'p',
            "props",
            HelpText = "The path to the binding's props file.",
            Required = true
        )]
        [NotNull]
        public string Props { get; set; }
    }
}
