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
    [NativeName("Name", "VkPhysicalDevicePerStageDescriptorSetFeaturesNV")]
    public unsafe partial struct PhysicalDevicePerStageDescriptorSetFeaturesNV : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDevicePerStageDescriptorSetFeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDevicePerStageDescriptorSetFeaturesNV,
            void* pNext = null,
            Bool32? perStageDescriptorSet = null,
            Bool32? dynamicPipelineLayout = null
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

            if (perStageDescriptorSet is not null)
            {
                PerStageDescriptorSet = perStageDescriptorSet.Value;
            }

            if (dynamicPipelineLayout is not null)
            {
                DynamicPipelineLayout = dynamicPipelineLayout.Value;
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
        [NativeName("Name", "perStageDescriptorSet")]
        public Bool32 PerStageDescriptorSet;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dynamicPipelineLayout")]
        public Bool32 DynamicPipelineLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePerStageDescriptorSetFeaturesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
