// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkConformanceVersionKHR")]
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
