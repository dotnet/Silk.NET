// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkComponentMapping")]
    public unsafe struct ComponentMapping
    {
        public ComponentMapping
        (
            ComponentSwizzle r = default,
            ComponentSwizzle g = default,
            ComponentSwizzle b = default,
            ComponentSwizzle a = default
        )
        {
           R = r;
           G = g;
           B = b;
           A = a;
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
