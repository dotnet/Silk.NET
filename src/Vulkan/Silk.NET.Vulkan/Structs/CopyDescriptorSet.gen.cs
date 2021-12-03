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
    [NativeName("Name", "VkCopyDescriptorSet")]
    public unsafe partial struct CopyDescriptorSet : IChainable
    {
        public CopyDescriptorSet
        (
            StructureType? sType = StructureType.CopyDescriptorSet,
            void* pNext = null,
            DescriptorSet? srcSet = null,
            uint? srcBinding = null,
            uint? srcArrayElement = null,
            DescriptorSet? dstSet = null,
            uint? dstBinding = null,
            uint? dstArrayElement = null,
            uint? descriptorCount = null
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

            if (srcSet is not null)
            {
                SrcSet = srcSet.Value;
            }

            if (srcBinding is not null)
            {
                SrcBinding = srcBinding.Value;
            }

            if (srcArrayElement is not null)
            {
                SrcArrayElement = srcArrayElement.Value;
            }

            if (dstSet is not null)
            {
                DstSet = dstSet.Value;
            }

            if (dstBinding is not null)
            {
                DstBinding = dstBinding.Value;
            }

            if (dstArrayElement is not null)
            {
                DstArrayElement = dstArrayElement.Value;
            }

            if (descriptorCount is not null)
            {
                DescriptorCount = descriptorCount.Value;
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
        [NativeName("Type", "VkDescriptorSet")]
        [NativeName("Type.Name", "VkDescriptorSet")]
        [NativeName("Name", "srcSet")]
        public DescriptorSet SrcSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcBinding")]
        public uint SrcBinding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcArrayElement")]
        public uint SrcArrayElement;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSet")]
        [NativeName("Type.Name", "VkDescriptorSet")]
        [NativeName("Name", "dstSet")]
        public DescriptorSet DstSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstBinding")]
        public uint DstBinding;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstArrayElement")]
        public uint DstArrayElement;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorCount")]
        public uint DescriptorCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyDescriptorSet;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
