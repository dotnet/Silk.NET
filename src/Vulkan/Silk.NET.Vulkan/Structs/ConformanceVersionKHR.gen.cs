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
    [NativeName("Name", "VkConformanceVersionKHR")]
    [NativeName("AliasOf", "VkConformanceVersion")]
    public unsafe partial struct ConformanceVersionKHR
    {
        public ConformanceVersionKHR
        (
            byte? major = null,
            byte? minor = null,
            byte? subminor = null,
            byte? patch = null
        ) : this()
        {
            if (major is not null)
            {
                Major = major.Value;
            }

            if (minor is not null)
            {
                Minor = minor.Value;
            }

            if (subminor is not null)
            {
                Subminor = subminor.Value;
            }

            if (patch is not null)
            {
                Patch = patch.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "major")]
        public byte Major;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "minor")]
        public byte Minor;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "subminor")]
        public byte Subminor;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "patch")]
        public byte Patch;
    }
}
