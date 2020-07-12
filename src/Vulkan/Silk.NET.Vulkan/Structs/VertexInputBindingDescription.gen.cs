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
    [NativeName("Name", "VkVertexInputBindingDescription")]
    public unsafe partial struct VertexInputBindingDescription
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
/// <summary></summary>
        [NativeName("Type", "VkVertexInputRate")]
        [NativeName("Type.Name", "VkVertexInputRate")]
        [NativeName("Name", "inputRate")]
        public VertexInputRate InputRate;
    }
}
