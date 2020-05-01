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
    public unsafe struct VertexInputBindingDescription
    {
        public VertexInputBindingDescription
        (
            uint binding = default,
            uint stride = default,
            VertexInputRate inputRate = default
        )
        {
           Binding = binding;
           Stride = stride;
           InputRate = inputRate;
        }

/// <summary></summary>
        public uint Binding;
/// <summary></summary>
        public uint Stride;
/// <summary></summary>
        public VertexInputRate InputRate;
    }
}
