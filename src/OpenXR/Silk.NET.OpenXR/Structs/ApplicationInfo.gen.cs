// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            uint? applicationVersion = null,
            uint? engineVersion = null,
            ulong? apiVersion = null
        ) : this()
        {
            if (applicationVersion is not null)
            {
                ApplicationVersion = applicationVersion.Value;
            }

            if (engineVersion is not null)
            {
                EngineVersion = engineVersion.Value;
            }

            if (apiVersion is not null)
            {
                ApiVersion = apiVersion.Value;
            }
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
