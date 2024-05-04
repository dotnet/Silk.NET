// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Silk.NET.BuildTools.Common;
using Silk.NET.Core.Attributes;

namespace Silk.NET.BuildTools
{
    public struct Config
    {
        [JsonProperty("tasks")] public BindTask[] Tasks { get; set; }
    }

    public class BindTask
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
        [JsonProperty("prefixOverrides")] public Dictionary<string, string> PrefixOverrides { get; set; } = new();
        [JsonProperty("namespace")] public string Namespace { get; set; }
        [JsonProperty("overloadExclusions")] public Dictionary<string, string[]>? OverloaderExclusions { get; set; }
        [JsonProperty("extensionsNamespace")] public string ExtensionsNamespace { get; set; }
        [JsonProperty("nameContainer")] public NameContainer NameContainer { get; set; }

        [JsonProperty("typeMaps")] public List<Dictionary<string, string>> TypeMaps { get; set; } = new();
        // TODO the following 2 properties are only implemented in Clang. implement on ConvertConstruct?
        [JsonProperty("exclude")] public List<string> ExcludedNativeNames { get; set; } = new();
        [JsonProperty("rename")] public Dictionary<string, string> RenamedNativeNames { get; set; } = new();
        [JsonProperty("copy")] public Dictionary<string, string> CopyFiles { get; set; } = new();
        [JsonProperty("glIntAsPtr")] public Dictionary<string, string[]> IntAsPtr { get; set; } = new();

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
        [JsonProperty("comRefs")] public HashSet<string> ComRefs { get; set; }
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
        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [JsonProperty("path")]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets the folder within the base output path where the binder will write the generated files, with
        /// the exception of the csproj.
        /// </summary>
        [JsonProperty("innerPath")]
        public string? Subfolder { get; set; }

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
        
        [JsonProperty("conditional")] public Dictionary<string, string[]> ConditionalFunctions { get; set; }
        [JsonProperty("inject")] public Injection[]? Injections { get; set; }
    }

    public struct Injection
    {
        [JsonProperty("functions")]
        public string[] FunctionNativeNames { get; set; }
        
        [JsonProperty("stage")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SilkTouchStage Stage { get; set; }
        
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public enum ConverterMode
    {
        ConvertConstruct,
        Clang
    }
}
