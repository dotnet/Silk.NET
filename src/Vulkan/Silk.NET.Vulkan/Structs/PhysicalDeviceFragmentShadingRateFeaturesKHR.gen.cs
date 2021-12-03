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
    [NativeName("Name", "VkPhysicalDeviceFragmentShadingRateFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceFragmentShadingRateFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceFragmentShadingRateFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentShadingRateFeaturesKhr,
            void* pNext = null,
            Bool32? pipelineFragmentShadingRate = null,
            Bool32? primitiveFragmentShadingRate = null,
            Bool32? attachmentFragmentShadingRate = null
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

            if (pipelineFragmentShadingRate is not null)
            {
                PipelineFragmentShadingRate = pipelineFragmentShadingRate.Value;
            }

            if (primitiveFragmentShadingRate is not null)
            {
                PrimitiveFragmentShadingRate = primitiveFragmentShadingRate.Value;
            }

            if (attachmentFragmentShadingRate is not null)
            {
                AttachmentFragmentShadingRate = attachmentFragmentShadingRate.Value;
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
        [NativeName("Name", "pipelineFragmentShadingRate")]
        public Bool32 PipelineFragmentShadingRate;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveFragmentShadingRate")]
        public Bool32 PrimitiveFragmentShadingRate;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "attachmentFragmentShadingRate")]
        public Bool32 AttachmentFragmentShadingRate;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFragmentShadingRateFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
