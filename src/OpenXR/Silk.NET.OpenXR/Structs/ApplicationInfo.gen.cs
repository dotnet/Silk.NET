// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrApplicationInfo")]
    public unsafe partial struct ApplicationInfo
    {
        public ApplicationInfo
        (
            uint applicationVersion = default,
            uint engineVersion = default,
            ulong apiVersion = default
        )
        {
            ApplicationVersion = applicationVersion;
            EngineVersion = engineVersion;
            ApiVersion = apiVersion;
        }

        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "applicationName")]
        public fixed byte ApplicationName[128];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "applicationVersion")]
        public uint ApplicationVersion;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "engineName")]
        public fixed byte EngineName[128];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "engineVersion")]
        public uint EngineVersion;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "apiVersion")]
        public ulong ApiVersion;
    }
}
