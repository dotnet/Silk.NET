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
    [NativeName("Name", "VkPhysicalDeviceNestedCommandBufferFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceNestedCommandBufferFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceNestedCommandBufferFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceNestedCommandBufferFeaturesExt,
            void* pNext = null,
            Bool32? nestedCommandBuffer = null,
            Bool32? nestedCommandBufferRendering = null,
            Bool32? nestedCommandBufferSimultaneousUse = null
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

            if (nestedCommandBuffer is not null)
            {
                NestedCommandBuffer = nestedCommandBuffer.Value;
            }

            if (nestedCommandBufferRendering is not null)
            {
                NestedCommandBufferRendering = nestedCommandBufferRendering.Value;
            }

            if (nestedCommandBufferSimultaneousUse is not null)
            {
                NestedCommandBufferSimultaneousUse = nestedCommandBufferSimultaneousUse.Value;
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
        [NativeName("Name", "nestedCommandBuffer")]
        public Bool32 NestedCommandBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nestedCommandBufferRendering")]
        public Bool32 NestedCommandBufferRendering;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nestedCommandBufferSimultaneousUse")]
        public Bool32 NestedCommandBufferSimultaneousUse;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceNestedCommandBufferFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
