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
    [NativeName("Name", "VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceUnifiedImageLayoutsFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceUnifiedImageLayoutsFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceUnifiedImageLayoutsFeaturesKhr,
            void* pNext = null,
            Bool32? unifiedImageLayouts = null,
            Bool32? unifiedImageLayoutsVideo = null
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

            if (unifiedImageLayouts is not null)
            {
                UnifiedImageLayouts = unifiedImageLayouts.Value;
            }

            if (unifiedImageLayoutsVideo is not null)
            {
                UnifiedImageLayoutsVideo = unifiedImageLayoutsVideo.Value;
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
        [NativeName("Name", "unifiedImageLayouts")]
        public Bool32 UnifiedImageLayouts;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "unifiedImageLayoutsVideo")]
        public Bool32 UnifiedImageLayoutsVideo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceUnifiedImageLayoutsFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
