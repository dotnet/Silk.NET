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
    [NativeName("Name", "VkMicromapTriangleEXT")]
    public unsafe partial struct MicromapTriangleEXT
    {
        public MicromapTriangleEXT
        (
            uint? dataOffset = null,
            ushort? subdivisionLevel = null,
            ushort? format = null
        ) : this()
        {
            if (dataOffset is not null)
            {
                DataOffset = dataOffset.Value;
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
        [NativeName("Name", "dataOffset")]
        public uint DataOffset;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "subdivisionLevel")]
        public ushort SubdivisionLevel;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "format")]
        public ushort Format;
    }
}
