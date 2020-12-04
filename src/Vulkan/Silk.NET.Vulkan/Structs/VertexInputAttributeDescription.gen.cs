// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkVertexInputAttributeDescription")]
    public unsafe partial struct VertexInputAttributeDescription
    {
        public VertexInputAttributeDescription
        (
            uint? location = null,
            uint? binding = null,
            Format? format = null,
            uint? offset = null
        ) : this()
        {
            if (location is not null)
            {
                Location = location.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "location")]
        public uint Location;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;
    }
}
