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
    [NativeName("Name", "VkPhysicalDeviceDepthStencilResolveProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceDepthStencilResolvePropertiesKHR")]
    public unsafe partial struct PhysicalDeviceDepthStencilResolveProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDepthStencilResolveProperties
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDepthStencilResolveProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
