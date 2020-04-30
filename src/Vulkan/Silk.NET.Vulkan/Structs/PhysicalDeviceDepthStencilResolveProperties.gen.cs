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
    public unsafe struct PhysicalDeviceDepthStencilResolveProperties
    {
        public PhysicalDeviceDepthStencilResolveProperties
        (
            StructureType sType = StructureType.PhysicalDeviceDepthStencilResolveProperties,
            void* pNext = default,
            ResolveModeFlags supportedDepthResolveModes = default,
            ResolveModeFlags supportedStencilResolveModes = default,
            Bool32 independentResolveNone = default,
            Bool32 independentResolve = default
        )
        {
           SType = sType;
           PNext = pNext;
           SupportedDepthResolveModes = supportedDepthResolveModes;
           SupportedStencilResolveModes = supportedStencilResolveModes;
           IndependentResolveNone = independentResolveNone;
           IndependentResolve = independentResolve;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ResolveModeFlags SupportedDepthResolveModes;
/// <summary></summary>
        public ResolveModeFlags SupportedStencilResolveModes;
/// <summary></summary>
        public Bool32 IndependentResolveNone;
/// <summary></summary>
        public Bool32 IndependentResolve;
    }
}
