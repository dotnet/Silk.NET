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
    [NativeName("Name", "VkVertexInputBindingDescription")]
    public unsafe partial struct VertexInputBindingDescription
    {
        public VertexInputBindingDescription
        (
            uint? binding = null,
            uint? stride = null,
            VertexInputRate? inputRate = null
        ) : this()
        {
            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (inputRate is not null)
            {
                InputRate = inputRate.Value;
            }
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
