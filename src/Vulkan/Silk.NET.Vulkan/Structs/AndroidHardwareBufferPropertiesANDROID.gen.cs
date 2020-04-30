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
    public unsafe struct AndroidHardwareBufferPropertiesANDROID
    {
        public AndroidHardwareBufferPropertiesANDROID
        (
            StructureType sType = StructureType.AndroidHardwareBufferPropertiesAndroid,
            void* pNext = default,
            ulong allocationSize = default,
            uint memoryTypeBits = default
        )
        {
           SType = sType;
           PNext = pNext;
           AllocationSize = allocationSize;
           MemoryTypeBits = memoryTypeBits;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong AllocationSize;
/// <summary></summary>
        public uint MemoryTypeBits;
    }
}
