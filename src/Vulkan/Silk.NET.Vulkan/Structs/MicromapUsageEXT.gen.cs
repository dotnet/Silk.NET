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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMicromapUsageEXT")]
    public unsafe partial struct MicromapUsageEXT
    {
        public MicromapUsageEXT
        (
            uint? count = null,
            uint? subdivisionLevel = null,
            uint? format = null
        ) : this()
        {
            if (count is not null)
            {
                Count = count.Value;
            }

            if (subdivisionLevel is not null)
            {
                SubdivisionLevel = subdivisionLevel.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "count")]
        public uint Count;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subdivisionLevel")]
        public uint SubdivisionLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "format")]
        public uint Format;
    }
}
