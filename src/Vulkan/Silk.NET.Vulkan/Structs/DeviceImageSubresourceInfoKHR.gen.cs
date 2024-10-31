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
    [NativeName("Name", "VkDeviceImageSubresourceInfoKHR")]
    public unsafe partial struct DeviceImageSubresourceInfoKHR : IChainable
    {
        public DeviceImageSubresourceInfoKHR
        (
            StructureType? sType = StructureType.DeviceImageSubresourceInfoKhr,
            void* pNext = null,
            ImageCreateInfo* pCreateInfo = null,
            ImageSubresource2KHR* pSubresource = null
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

            if (pSubresource is not null)
            {
                PSubresource = pSubresource;
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
        [NativeName("Type", "VkImageSubresource2KHR*")]
        [NativeName("Type.Name", "VkImageSubresource2KHR")]
        [NativeName("Name", "pSubresource")]
        public ImageSubresource2KHR* PSubresource;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceImageSubresourceInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
