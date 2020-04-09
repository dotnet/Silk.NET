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
    public unsafe struct VertexInputAttributeDescription
    {
        public VertexInputAttributeDescription
        (
            uint location = default,
            uint binding = default,
            Format format = default,
            uint offset = default
        )
        {
           Location = location;
           Binding = binding;
           Format = format;
           Offset = offset;
        }

/// <summary></summary>
        public uint Location;
/// <summary></summary>
        public uint Binding;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public uint Offset;
    }
}
