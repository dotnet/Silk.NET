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
    [NativeName("Name", "VkImageDrmFormatModifierListCreateInfoEXT")]
    public unsafe partial struct ImageDrmFormatModifierListCreateInfoEXT : IExtendsChain<ImageCreateInfo>
    {
        public ImageDrmFormatModifierListCreateInfoEXT
        (
            StructureType? sType = StructureType.ImageDrmFormatModifierListCreateInfoExt,
            void* pNext = null,
            uint? drmFormatModifierCount = null,
            ulong* pDrmFormatModifiers = null
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

            if (drmFormatModifierCount is not null)
            {
                DrmFormatModifierCount = drmFormatModifierCount.Value;
            }

            if (pDrmFormatModifiers is not null)
            {
                PDrmFormatModifiers = pDrmFormatModifiers;
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
        [NativeName("Name", "drmFormatModifierCount")]
        public uint DrmFormatModifierCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pDrmFormatModifiers")]
        public ulong* PDrmFormatModifiers;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageDrmFormatModifierListCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
