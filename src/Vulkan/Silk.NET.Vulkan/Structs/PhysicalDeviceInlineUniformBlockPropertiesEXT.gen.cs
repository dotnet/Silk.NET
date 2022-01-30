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
    [NativeName("Name", "VkPhysicalDeviceInlineUniformBlockPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceInlineUniformBlockPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceInlineUniformBlockPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceInlineUniformBlockPropertiesExt,
            void* pNext = null,
            uint? maxInlineUniformBlockSize = null,
            uint? maxPerStageDescriptorInlineUniformBlocks = null,
            uint? maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = null,
            uint? maxDescriptorSetInlineUniformBlocks = null,
            uint? maxDescriptorSetUpdateAfterBindInlineUniformBlocks = null
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

            if (maxInlineUniformBlockSize is not null)
            {
                MaxInlineUniformBlockSize = maxInlineUniformBlockSize.Value;
            }

            if (maxPerStageDescriptorInlineUniformBlocks is not null)
            {
                MaxPerStageDescriptorInlineUniformBlocks = maxPerStageDescriptorInlineUniformBlocks.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks.Value;
            }

            if (maxDescriptorSetInlineUniformBlocks is not null)
            {
                MaxDescriptorSetInlineUniformBlocks = maxDescriptorSetInlineUniformBlocks.Value;
            }

            if (maxDescriptorSetUpdateAfterBindInlineUniformBlocks is not null)
            {
                MaxDescriptorSetUpdateAfterBindInlineUniformBlocks = maxDescriptorSetUpdateAfterBindInlineUniformBlocks.Value;
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
        [NativeName("Name", "maxInlineUniformBlockSize")]
        public uint MaxInlineUniformBlockSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorInlineUniformBlocks")]
        public uint MaxPerStageDescriptorInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks")]
        public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetInlineUniformBlocks")]
        public uint MaxDescriptorSetInlineUniformBlocks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindInlineUniformBlocks")]
        public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceInlineUniformBlockPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
