// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Convert.Baking;

namespace Silk.NET.BuildTools.Convert
{
    /// <summary>
    /// The entry point for the bindings converter.
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Gets or sets the parsed command-line arguments.
        /// </summary>
        public static ConvertOptions CliOptions { get; set; }

        /// <summary>
        /// The entry point for the bindings converter.
        /// </summary>
        /// <param name="args">The raw command-line arguments.</param>
        public static void Convert(ConvertOptions args)
        {
            CliOptions = args;
            using (var profileConstructor = new ProfileConstructor
            {
                InputFiles = CliOptions.InputFiles.ToList(),
                OutputFolder = CliOptions.OutputFolder,
                Pretty = CliOptions.PrettyPrinted,
                Prefix = CliOptions.Prefix,
                TypeMaps = CliOptions.Typemap.Any()
                    ? CliOptions.Typemap.Select(File.ReadAllText)
                        .Select(JsonConvert.DeserializeObject<Dictionary<string, string>>)
                        .ToList()
                    : null
            })
            {
                profileConstructor.WriteProfiles();
            }

            Console.WriteLine("Baking raw profiles...");
            ProfileBakery.Bake
            (
                CliOptions.BakeryInformation
                    .Select(File.ReadAllText)
                    .SelectMany(JsonConvert.DeserializeObject<ProfileBakeryInformation[]>),
                CliOptions.OutputFolder,
                CliOptions.PrettyPrinted
            );
            Console.WriteLine("Finishing up...");
            if (!CliOptions.PreserveRawAPIs)
            {
                ProfileBakery.DeleteRawAPIs(CliOptions.OutputFolder);
            }
        }
    }
}
