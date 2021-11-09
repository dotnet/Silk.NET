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
    [NativeName("Name", "VkImageFormatListCreateInfoKHR")]
    [NativeName("AliasOf", "VkImageFormatListCreateInfo")]
    public unsafe partial struct ImageFormatListCreateInfoKHR : IExtendsChain<ImageCreateInfo>, IExtendsChain<SwapchainCreateInfoKHR>, IExtendsChain<PhysicalDeviceImageFormatInfo2>, IExtendsChain<PhysicalDeviceImageFormatInfo2KHR>
    {
        public ImageFormatListCreateInfoKHR
        (
            StructureType? sType = StructureType.ImageFormatListCreateInfo,
            void* pNext = null,
            uint? viewFormatCount = null,
            Format* pViewFormats = null
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

            if (viewFormatCount is not null)
            {
                ViewFormatCount = viewFormatCount.Value;
            }

            if (pViewFormats is not null)
            {
                PViewFormats = pViewFormats;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewFormatCount")]
        public uint ViewFormatCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat*")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pViewFormats")]
        public Format* PViewFormats;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageFormatListCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
