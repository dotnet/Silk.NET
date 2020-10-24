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
    [NativeName("Name", "VkAllocationCallbacks")]
    public unsafe partial struct AllocationCallbacks
    {
        public AllocationCallbacks
        (
            void* pUserData = null,
            FuncPtr? pfnAllocation = null,
            FuncPtr? pfnReallocation = null,
            FuncPtr? pfnFree = null,
            FuncPtr? pfnInternalAllocation = null,
            FuncPtr? pfnInternalFree = null
        ) : this()
        {
            if (pUserData is not null)
            {
                PUserData = pUserData;
            }

            if (pfnAllocation is not null)
            {
                PfnAllocation = pfnAllocation.Value;
            }

            if (pfnReallocation is not null)
            {
                PfnReallocation = pfnReallocation.Value;
            }

            if (pfnFree is not null)
            {
                PfnFree = pfnFree.Value;
            }

            if (pfnInternalAllocation is not null)
            {
                PfnInternalAllocation = pfnInternalAllocation.Value;
            }

            if (pfnInternalFree is not null)
            {
                PfnInternalFree = pfnInternalFree.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;
/// <summary></summary>
        [NativeName("Type", "PFN_vkAllocationFunction")]
        [NativeName("Type.Name", "PFN_vkAllocationFunction")]
        [NativeName("Name", "pfnAllocation")]
        public FuncPtr PfnAllocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkReallocationFunction")]
        [NativeName("Type.Name", "PFN_vkReallocationFunction")]
        [NativeName("Name", "pfnReallocation")]
        public FuncPtr PfnReallocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkFreeFunction")]
        [NativeName("Type.Name", "PFN_vkFreeFunction")]
        [NativeName("Name", "pfnFree")]
        public FuncPtr PfnFree;
/// <summary></summary>
        [NativeName("Type", "PFN_vkInternalAllocationNotification")]
        [NativeName("Type.Name", "PFN_vkInternalAllocationNotification")]
        [NativeName("Name", "pfnInternalAllocation")]
        public FuncPtr PfnInternalAllocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkInternalFreeNotification")]
        [NativeName("Type.Name", "PFN_vkInternalFreeNotification")]
        [NativeName("Name", "pfnInternalFree")]
        public FuncPtr PfnInternalFree;
    }
}
