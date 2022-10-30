// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a platform name container.
    /// </summary>
    public class NameContainer
    {
        /// <summary>
        /// Gets or sets the Linux library name.
        /// </summary>
        [JsonProperty("linux-x64")] 
        public string Linux { get; set; }

        /// <summary>
        /// Gets or sets the Windows x64 library name.
        /// </summary>
        [JsonProperty("win-x64")]
        public string Windows64 { get; set; }

        /// <summary>
        /// Gets or sets the Windows x64 library name.
        /// </summary>
        [JsonProperty("win-x86")]
        public string Windows86 { get; set; }

        /// <summary>
        /// Gets or sets the OSX library name.
        /// </summary>
        [JsonProperty("osx-x64")]
        public string MacOS { get; set; }

        /// <summary>
        /// Gets or sets the Android library name.
        /// </summary>
        [JsonProperty("android")]
        public string Android { get; set; }

        /// <summary>
        /// Gets or sets the iOS library name.
        /// </summary>
        [JsonProperty("iOS")]
        public string IOS { get; set; }
        
        /// <summary>
        /// Gets or sets the browser library name.
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// Gets or sets the class name of the output name container.
        /// </summary>
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }
}
