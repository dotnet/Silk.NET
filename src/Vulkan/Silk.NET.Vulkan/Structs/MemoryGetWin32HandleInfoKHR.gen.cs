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
    public unsafe struct MemoryGetWin32HandleInfoKHR
    {
        public MemoryGetWin32HandleInfoKHR
        (
            StructureType sType = StructureType.MemoryGetWin32HandleInfoKhr,
            void* pNext = default,
            DeviceMemory memory = default,
            ExternalMemoryHandleTypeFlags handleType = default
        )
        {
           SType = sType;
           PNext = pNext;
           Memory = memory;
           HandleType = handleType;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags HandleType;
    }
}
