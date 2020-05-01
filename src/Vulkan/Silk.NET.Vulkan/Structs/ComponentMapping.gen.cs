// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public ComponentSwizzle R;
/// <summary></summary>
        public ComponentSwizzle G;
/// <summary></summary>
        public ComponentSwizzle B;
/// <summary></summary>
        public ComponentSwizzle A;
    }
}
