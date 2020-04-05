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
    public unsafe struct AllocationCallbacks
    {
        public AllocationCallbacks
        (
            void* pUserData = default,
            FuncPtr pfnAllocation = default,
            FuncPtr pfnReallocation = default,
            FuncPtr pfnFree = default,
            FuncPtr pfnInternalAllocation = default,
            FuncPtr pfnInternalFree = default
        )
        {
           PUserData = pUserData;
           PfnAllocation = pfnAllocation;
           PfnReallocation = pfnReallocation;
           PfnFree = pfnFree;
           PfnInternalAllocation = pfnInternalAllocation;
           PfnInternalFree = pfnInternalFree;
        }

/// <summary></summary>
        public void* PUserData;
/// <summary></summary>
        public FuncPtr PfnAllocation;
/// <summary></summary>
        public FuncPtr PfnReallocation;
/// <summary></summary>
        public FuncPtr PfnFree;
/// <summary></summary>
        public FuncPtr PfnInternalAllocation;
/// <summary></summary>
        public FuncPtr PfnInternalFree;
    }
}
