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
    [NativeName("Name", "VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr,
            void* pNext = null,
            Bool32? shaderZeroInitializeWorkgroupMemory = null
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

            if (shaderZeroInitializeWorkgroupMemory is not null)
            {
                ShaderZeroInitializeWorkgroupMemory = shaderZeroInitializeWorkgroupMemory.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderZeroInitializeWorkgroupMemory")]
        public Bool32 ShaderZeroInitializeWorkgroupMemory;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
