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
    [NativeName("Name", "VkDeviceImageMemoryRequirementsKHR")]
    public unsafe partial struct DeviceImageMemoryRequirementsKHR : IChainable
    {
        public DeviceImageMemoryRequirementsKHR
        (
            StructureType? sType = StructureType.DeviceImageMemoryRequirementsKhr,
            void* pNext = null,
            ImageCreateInfo* pCreateInfo = null,
            ImageAspectFlags? planeAspect = null
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

            if (pCreateInfo is not null)
            {
                PCreateInfo = pCreateInfo;
            }

            if (planeAspect is not null)
            {
                PlaneAspect = planeAspect.Value;
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
        [NativeName("Type", "VkImageCreateInfo*")]
        [NativeName("Type.Name", "VkImageCreateInfo")]
        [NativeName("Name", "pCreateInfo")]
        public ImageCreateInfo* PCreateInfo;
/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlagBits")]
        [NativeName("Type.Name", "VkImageAspectFlagBits")]
        [NativeName("Name", "planeAspect")]
        public ImageAspectFlags PlaneAspect;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceImageMemoryRequirementsKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
