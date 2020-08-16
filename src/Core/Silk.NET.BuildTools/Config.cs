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

        [JsonProperty("mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConverterMode Mode { get; set; }

        [JsonProperty("cacheDir")] public string CacheFolder { get; set; }
        [JsonProperty("cacheKey")] public string CacheKey { get; set; }
        [JsonProperty("controlDescriptors")] public string[] Controls { get; set; }
        [JsonProperty("converter")] public ConverterOptions ConverterOpts { get; set; }
        [JsonProperty("clang")] public ClangTaskOptions ClangOpts { get; set; }
        [JsonProperty("bakery")] public BakeryOptions BakeryOpts { get; set; }
        [JsonProperty("output")] public OutputOptions OutputOpts { get; set; }
        [JsonProperty("prefix")] public string FunctionPrefix { get; set; }
        [JsonProperty("namespace")] public string Namespace { get; set; }
        [JsonProperty("extensionsNamespace")] public string ExtensionsNamespace { get; set; }
        [JsonProperty("nameContainer")] public NameContainer NameContainer { get; set; }
        [JsonProperty("typeMaps")] public List<Dictionary<string, string>> TypeMaps { get; set; }
        // TODO the following 2 properties are only implemented in Clang. implement on ConvertConstruct?
        [JsonProperty("exclude")] public List<string> ExcludedNativeNames { get; set; }
        [JsonProperty("rename")] public Dictionary<string, string> RenamedNativeNames { get; set; }

        public void InjectTypeMap(Dictionary<string, string> map)
            => TypeMaps.Insert
            (
                NoM1
                (
                    TypeMaps.FindIndex
                    (
                        x => x.TryGetValue("$typemapPrecedesInjections", out var val)
                             && bool.TryParse(val, out var valVal)
                             && valVal
                    )
                ), map
            );

        private int NoM1(int val) => val == -1 ? 0 : val;
    }

    public struct ClangTaskOptions
    {
        [JsonProperty("args")] public string[] ClangArgs { get; set; }
        [JsonProperty("traverse")] public string[] Traverse { get; set; }
        [JsonProperty("classes")] public Dictionary<string, string> ClassMappings { get; set; }
    }

    public struct BakeryOptions
    {
        [JsonProperty("profileNames")] public string[] Include { get; set; }
    }

    public struct ConverterOptions
    {
        [JsonProperty("className")] public string ClassName { get; set; }
        [JsonProperty("reader")] public string Reader { get; set; }
        [JsonProperty("constructor")] public string Constructor { get; set; }
    }

    public struct OutputOptions
    {
        [JsonProperty("mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OutputMode Mode { get; set; }

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

    public enum ConverterMode
    {
        ConvertConstruct,
        Clang
    }

    public enum OutputMode
    {
        Default = 1, // fnptrs, for now just use super invoke
        Legacy = 1 // super invoke
    }
}
