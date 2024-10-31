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
    [NativeName("Name", "VkPhysicalDeviceDescriptorBufferFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceDescriptorBufferFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceDescriptorBufferFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDescriptorBufferFeaturesExt,
            void* pNext = null,
            Bool32? descriptorBuffer = null,
            Bool32? descriptorBufferCaptureReplay = null,
            Bool32? descriptorBufferImageLayoutIgnored = null,
            Bool32? descriptorBufferPushDescriptors = null
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

            if (descriptorBuffer is not null)
            {
                DescriptorBuffer = descriptorBuffer.Value;
            }

            if (descriptorBufferCaptureReplay is not null)
            {
                DescriptorBufferCaptureReplay = descriptorBufferCaptureReplay.Value;
            }

            if (descriptorBufferImageLayoutIgnored is not null)
            {
                DescriptorBufferImageLayoutIgnored = descriptorBufferImageLayoutIgnored.Value;
            }

            if (descriptorBufferPushDescriptors is not null)
            {
                DescriptorBufferPushDescriptors = descriptorBufferPushDescriptors.Value;
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
        [NativeName("Name", "descriptorBuffer")]
        public Bool32 DescriptorBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBufferCaptureReplay")]
        public Bool32 DescriptorBufferCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBufferImageLayoutIgnored")]
        public Bool32 DescriptorBufferImageLayoutIgnored;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBufferPushDescriptors")]
        public Bool32 DescriptorBufferPushDescriptors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDescriptorBufferFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
