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
    [NativeName("Name", "VkPhysicalDeviceHostImageCopyPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceHostImageCopyPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceHostImageCopyPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceHostImageCopyPropertiesExt,
            void* pNext = null,
            uint? copySrcLayoutCount = null,
            ImageLayout* pCopySrcLayouts = null,
            uint? copyDstLayoutCount = null,
            ImageLayout* pCopyDstLayouts = null,
            Bool32? identicalMemoryTypeRequirements = null
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

            if (copySrcLayoutCount is not null)
            {
                CopySrcLayoutCount = copySrcLayoutCount.Value;
            }

            if (pCopySrcLayouts is not null)
            {
                PCopySrcLayouts = pCopySrcLayouts;
            }

            if (copyDstLayoutCount is not null)
            {
                CopyDstLayoutCount = copyDstLayoutCount.Value;
            }

            if (pCopyDstLayouts is not null)
            {
                PCopyDstLayouts = pCopyDstLayouts;
            }

            if (identicalMemoryTypeRequirements is not null)
            {
                IdenticalMemoryTypeRequirements = identicalMemoryTypeRequirements.Value;
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
        [NativeName("Name", "copySrcLayoutCount")]
        public uint CopySrcLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout*")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "pCopySrcLayouts")]
        public ImageLayout* PCopySrcLayouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "copyDstLayoutCount")]
        public uint CopyDstLayoutCount;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout*")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "pCopyDstLayouts")]
        public ImageLayout* PCopyDstLayouts;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "optimalTilingLayoutUUID")]
        public fixed byte OptimalTilingLayoutUuid[16];
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "identicalMemoryTypeRequirements")]
        public Bool32 IdenticalMemoryTypeRequirements;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceHostImageCopyPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
