// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using CommandLine;

namespace Silk.NET.BuildTools.Baking
{
    /// <summary>
    /// The options to use when baking.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BakeryOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the raw (unbaked) API files should be kept.
        /// </summary>
        [Option
        (
            'k',
            "preserve",
            HelpText = "Indicates that the raw (unbaked) API files shouldn't be deleted.",
            Default = false
        )]
        // ReSharper thinks this is "Ap Is" instead of "APIs",
        // so it doesn't recognize the abbreviation in dotsettings.
        // ReSharper disable once InconsistentNaming
        public bool PreserveRawAPIs { get; set; } = false;

        /// <summary>
        /// Gets or sets the folder in which a docs.gl clone is contained.
        /// </summary>
        [Option('d', "docs", HelpText = "The folder in which a docs.gl clone is contained.", Required = false)]
        public string DocumentationFolder { get; set; }

        /// <summary>
        /// Gets or sets a list of paths to JSON <see cref="ProfileBakeryInformation" /> files.
        /// </summary>
        [Option
        (
            'b',
            "bakery-info",
            HelpText = "A list of paths to JSON ProfileBakeryInformation files.",
            Required = true
        )]
        public IEnumerable<string> BakeryInformation { get; set; }

        /// <summary>
        /// Gets or sets the path to the output file. Defaults to stdout if no path is provided.
        /// </summary>
        [Option
        (
            'f',
            "folder",
            HelpText = "The folder that the profiles should be written to.",
            Required = true
        )]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output files should be pretty printed.
        /// </summary>
        [Option
        (
            'p',
            "pretty",
            HelpText = "Indicates that the output files should be pretty printed.",
            Default = false
        )]
        public bool PrettyPrinted { get; set; } = false;
    }
}
