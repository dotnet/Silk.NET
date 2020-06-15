// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;
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
        [JsonProperty("mode")] public ConverterMode Mode { get; set; }
        [JsonProperty("cacheKey")] public string CacheKey { get; set; }
        [JsonProperty("controlDescriptors")] public string[] Controls { get; set; } 
        [JsonProperty("clang")] public ClangTaskOptions ClangOpts { get; set; }
        [JsonProperty("namespace")] public string Namespace { get; set; }
        [JsonProperty("extensionsNamespace")] public string ExtensionsNamespace { get; set; }
        [JsonProperty("outputMode")] public OutputMode OutputMode { get; set; }
        [JsonProperty("legacyNameContainer")] public NameContainer NameContainer { get; set; }
    }

    public struct ClangTaskOptions
    {
        [JsonProperty("include")]
        public string[] Include { get; set; }
        [JsonProperty("args")]
        public string[] ClangArgs { get; set; }
        [JsonProperty("projects")]
        public Dictionary<string, string> ProjectMappings { get; set; }
    }

    public struct BakeryOptions
    {
    }

    public enum ConverterMode
    {
        ConvertConstruct,
        ConvertConstructBake,
        ClangBake,
        Clang
    }

    public enum OutputMode
    {
        DefaultFunctionPointers = 1, // for now just use super invoke
        LegacySuperInvoke = 1
    }
}
