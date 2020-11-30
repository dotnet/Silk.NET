// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDeviceDepthStencilResolvePropertiesKHR")]
    public unsafe partial struct PhysicalDeviceDepthStencilResolvePropertiesKHR
    {
        public PhysicalDeviceDepthStencilResolvePropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceDepthStencilResolveProperties,
            void* pNext = null,
            ResolveModeFlags? supportedDepthResolveModes = null,
            ResolveModeFlags? supportedStencilResolveModes = null,
            Bool32? independentResolveNone = null,
            Bool32? independentResolve = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (supportedDepthResolveModes is not null)
            {
                SupportedDepthResolveModes = supportedDepthResolveModes.Value;
            }

            if (supportedStencilResolveModes is not null)
            {
                SupportedStencilResolveModes = supportedStencilResolveModes.Value;
            }

            if (independentResolveNone is not null)
            {
                IndependentResolveNone = independentResolveNone.Value;
            }

            if (independentResolve is not null)
            {
                IndependentResolve = independentResolve.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlags")]
        [NativeName("Type.Name", "VkResolveModeFlags")]
        [NativeName("Name", "supportedDepthResolveModes")]
        public ResolveModeFlags SupportedDepthResolveModes;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlags")]
        [NativeName("Type.Name", "VkResolveModeFlags")]
        [NativeName("Name", "supportedStencilResolveModes")]
        public ResolveModeFlags SupportedStencilResolveModes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "independentResolveNone")]
        public Bool32 IndependentResolveNone;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "independentResolve")]
        public Bool32 IndependentResolve;
    }
}
