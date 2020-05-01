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
    public unsafe struct SparseImageMemoryBind
    {
        public SparseImageMemoryBind
        (
            ImageSubresource subresource = default,
            Offset3D offset = default,
            Extent3D extent = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            SparseMemoryBindFlags flags = default
        )
        {
           Subresource = subresource;
           Offset = offset;
           Extent = extent;
           Memory = memory;
           MemoryOffset = memoryOffset;
           Flags = flags;
        }

/// <summary></summary>
        public ImageSubresource Subresource;
/// <summary></summary>
        public Offset3D Offset;
/// <summary></summary>
        public Extent3D Extent;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ulong MemoryOffset;
/// <summary></summary>
        public SparseMemoryBindFlags Flags;
    }
}
