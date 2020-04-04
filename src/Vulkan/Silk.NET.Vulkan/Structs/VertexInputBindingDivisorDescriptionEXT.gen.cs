// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct VertexInputBindingDivisorDescriptionEXT
    {
        public VertexInputBindingDivisorDescriptionEXT
        (
            uint binding = default,
            uint divisor = default
        )
        {
           Binding = binding;
           Divisor = divisor;
        }

/// <summary></summary>
        public uint Binding;
/// <summary></summary>
        public uint Divisor;
    }
}
