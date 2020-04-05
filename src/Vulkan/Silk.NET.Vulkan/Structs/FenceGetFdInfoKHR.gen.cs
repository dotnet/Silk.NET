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
    public unsafe struct FenceGetFdInfoKHR
    {
        public FenceGetFdInfoKHR
        (
            StructureType sType = StructureType.FenceGetFDInfoKhr,
            void* pNext = default,
            Fence fence = default,
            ExternalFenceHandleTypeFlags handleType = default
        )
        {
           SType = sType;
           PNext = pNext;
           Fence = fence;
           HandleType = handleType;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Fence Fence;
/// <summary></summary>
        public ExternalFenceHandleTypeFlags HandleType;
    }
}
