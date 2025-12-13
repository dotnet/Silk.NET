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
    [NativeName("Name", "VkCopyImageToMemoryInfo")]
    [NativeName("Aliases", "VkCopyImageToMemoryInfoEXT")]
    public unsafe partial struct CopyImageToMemoryInfo : IChainable
    {
        public CopyImageToMemoryInfo
        (
            StructureType? sType = StructureType.CopyImageToMemoryInfo,
            void* pNext = null,
            HostImageCopyFlags? flags = null,
            Image? srcImage = null,
            ImageLayout? srcImageLayout = null,
            uint? regionCount = null,
            ImageToMemoryCopy* pRegions = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (srcImage is not null)
            {
                SrcImage = srcImage.Value;
            }

            if (srcImageLayout is not null)
            {
                SrcImageLayout = srcImageLayout.Value;
            }

            if (regionCount is not null)
            {
                RegionCount = regionCount.Value;
            }

            if (pRegions is not null)
            {
                PRegions = pRegions;
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
        [NativeName("Type", "VkHostImageCopyFlags")]
        [NativeName("Type.Name", "VkHostImageCopyFlags")]
        [NativeName("Name", "flags")]
        public HostImageCopyFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "srcImage")]
        public Image SrcImage;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "srcImageLayout")]
        public ImageLayout SrcImageLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkImageToMemoryCopy*")]
        [NativeName("Type.Name", "VkImageToMemoryCopy")]
        [NativeName("Name", "pRegions")]
        public ImageToMemoryCopy* PRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyImageToMemoryInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
