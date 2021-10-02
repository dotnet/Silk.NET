// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkAllocationCallbacks")]
    public unsafe partial struct AllocationCallbacks
    {
        public AllocationCallbacks
        (
            void* pUserData = null,
            PfnAllocationFunction? pfnAllocation = null,
            PfnReallocationFunction? pfnReallocation = null,
            PfnFreeFunction? pfnFree = null,
            PfnInternalAllocationNotification? pfnInternalAllocation = null,
            PfnInternalFreeNotification? pfnInternalFree = null
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
        public PfnAllocationFunction PfnAllocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkReallocationFunction")]
        [NativeName("Type.Name", "PFN_vkReallocationFunction")]
        [NativeName("Name", "pfnReallocation")]
        public PfnReallocationFunction PfnReallocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkFreeFunction")]
        [NativeName("Type.Name", "PFN_vkFreeFunction")]
        [NativeName("Name", "pfnFree")]
        public PfnFreeFunction PfnFree;
/// <summary></summary>
        [NativeName("Type", "PFN_vkInternalAllocationNotification")]
        [NativeName("Type.Name", "PFN_vkInternalAllocationNotification")]
        [NativeName("Name", "pfnInternalAllocation")]
        public PfnInternalAllocationNotification PfnInternalAllocation;
/// <summary></summary>
        [NativeName("Type", "PFN_vkInternalFreeNotification")]
        [NativeName("Type.Name", "PFN_vkInternalFreeNotification")]
        [NativeName("Name", "pfnInternalFree")]
        public PfnInternalFreeNotification PfnInternalFree;
    }
}
