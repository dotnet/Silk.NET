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
    public unsafe struct PhysicalDeviceExternalBufferInfo
    {
        public PhysicalDeviceExternalBufferInfo
        (
            StructureType sType = StructureType.PhysicalDeviceExternalBufferInfo,
            void* pNext = default,
            BufferCreateFlags flags = default,
            BufferUsageFlags usage = default,
            ExternalMemoryHandleTypeFlags handleType = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Usage = usage;
           HandleType = handleType;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public BufferCreateFlags Flags;
/// <summary></summary>
        public BufferUsageFlags Usage;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags HandleType;
    }
}
