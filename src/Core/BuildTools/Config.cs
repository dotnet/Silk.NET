// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools
{
    public struct Config
    {
        [JsonProperty("tasks")] public BindTask[] Tasks { get; set; }
    }

    public struct BindTask
    {
        // TODO the dishwasher
        [JsonProperty("profileName")] public string Name { get; set; }
        [JsonProperty("sources")] public string[] Sources { get; set; }
        [JsonProperty("cacheDir")] public string CacheFolder { get; set; }
        [JsonProperty("cacheKey")] public string CacheKey { get; set; }
        [JsonProperty("controlDescriptors")] public string[] Controls { get; set; }
        [JsonProperty("converter")] public ConverterOptions ConverterOpts { get; set; }
        [JsonProperty("bakery")] public BakerySettings BakeryOpts { get; set; }
        [JsonProperty("output")] public OutputOptions OutputOpts { get; set; }
        [JsonProperty("namespace")] public string Namespace { get; set; }
        [JsonProperty("extensionsNamespace")] public string ExtensionsNamespace { get; set; }
        [JsonProperty("legacyNameContainer")] public NameContainer NameContainer { get; set; }
        [JsonProperty("typeMaps")] public List<Dictionary<string, string>> TypeMaps { get; set; }
    }

    public struct ClangTaskOptions
    {
        [JsonProperty("args")] public string[] ClangArgs { get; set; }
        [JsonProperty("classes")] public Dictionary<string, string> ClassMappings { get; set; }
    }

    public struct BakerySettings
    {
        [JsonProperty("profileNames")] public string[] Include { get; set; }
    }

    public struct ConverterOptions
    {
        [JsonProperty("className")] public string ClassName { get; set; }
        [JsonProperty("reader")] public string Reader { get; set; }
        [JsonProperty("constructor")] public string Constructor { get; set; }
        [JsonProperty("prefix")] public string FunctionPrefix { get; set; }
        [JsonProperty("args")] public string[] AdditionalArgs { get; set; }
    }

    public struct OutputOptions
    {
        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [JsonProperty("path")]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets the path to the license header.
        /// </summary>
        [JsonProperty("licenseFile")]
        public string License { get; set; }

        /// <summary>
        /// Gets or sets the path to the binding's props file.
        /// </summary>
        [JsonProperty("props")]
        public string Props { get; set; }
    }
}
