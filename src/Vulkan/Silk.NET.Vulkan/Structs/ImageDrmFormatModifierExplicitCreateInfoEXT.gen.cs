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
    [NativeName("Name", "VkImageDrmFormatModifierExplicitCreateInfoEXT")]
    public unsafe partial struct ImageDrmFormatModifierExplicitCreateInfoEXT : IExtendsChain<ImageCreateInfo>
    {
        public ImageDrmFormatModifierExplicitCreateInfoEXT
        (
            StructureType? sType = StructureType.ImageDrmFormatModifierExplicitCreateInfoExt,
            void* pNext = null,
            ulong? drmFormatModifier = null,
            uint? drmFormatModifierPlaneCount = null,
            SubresourceLayout* pPlaneLayouts = null
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

            if (drmFormatModifier is not null)
            {
                DrmFormatModifier = drmFormatModifier.Value;
            }

            if (drmFormatModifierPlaneCount is not null)
            {
                DrmFormatModifierPlaneCount = drmFormatModifierPlaneCount.Value;
            }

            if (pPlaneLayouts is not null)
            {
                PPlaneLayouts = pPlaneLayouts;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmFormatModifier")]
        public ulong DrmFormatModifier;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "drmFormatModifierPlaneCount")]
        public uint DrmFormatModifierPlaneCount;
/// <summary></summary>
        [NativeName("Type", "VkSubresourceLayout*")]
        [NativeName("Type.Name", "VkSubresourceLayout")]
        [NativeName("Name", "pPlaneLayouts")]
        public SubresourceLayout* PPlaneLayouts;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageDrmFormatModifierExplicitCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
