// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Generator.Convert.Baking;
using Newtonsoft.Json;

namespace Generator.Convert
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

            ProfileBakery.Bake
            (
                CliOptions.BakeryInformation.Any()
                    ? CliOptions.BakeryInformation.Select(File.ReadAllText)
                        .Select(JsonConvert.DeserializeObject<ProfileBakeryInformation>)
                    : ProfileBakeryInformation.Default,
                CliOptions.OutputFolder,
                CliOptions.PrettyPrinted
            );
            if (!CliOptions.PreserveRawAPIs)
            {
                ProfileBakery.DeleteRawAPIs(CliOptions.OutputFolder);
            }
        }
    }
}
