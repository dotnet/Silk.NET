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
    [NativeName("Name", "VkComponentMapping")]
    public unsafe partial struct ComponentMapping
    {
        public ComponentMapping
        (
            ComponentSwizzle? r = null,
            ComponentSwizzle? g = null,
            ComponentSwizzle? b = null,
            ComponentSwizzle? a = null
        ) : this()
        {
            if (r is not null)
            {
                R = r.Value;
            }

            if (g is not null)
            {
                G = g.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "r")]
        public ComponentSwizzle R;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "g")]
        public ComponentSwizzle G;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "b")]
        public ComponentSwizzle B;
/// <summary></summary>
        [NativeName("Type", "VkComponentSwizzle")]
        [NativeName("Type.Name", "VkComponentSwizzle")]
        [NativeName("Name", "a")]
        public ComponentSwizzle A;
    }
}
