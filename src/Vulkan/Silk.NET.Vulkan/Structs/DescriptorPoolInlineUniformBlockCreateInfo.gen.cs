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
    [NativeName("Name", "VkDescriptorPoolInlineUniformBlockCreateInfo")]
    [NativeName("Aliases", "VkDescriptorPoolInlineUniformBlockCreateInfoEXT")]
    public unsafe partial struct DescriptorPoolInlineUniformBlockCreateInfo : IExtendsChain<DescriptorPoolCreateInfo>
    {
        public DescriptorPoolInlineUniformBlockCreateInfo
        (
            StructureType? sType = StructureType.DescriptorPoolInlineUniformBlockCreateInfo,
            void* pNext = null,
            uint? maxInlineUniformBlockBindings = null
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

            if (maxInlineUniformBlockBindings is not null)
            {
                MaxInlineUniformBlockBindings = maxInlineUniformBlockBindings.Value;
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
        [NativeName("Name", "maxInlineUniformBlockBindings")]
        public uint MaxInlineUniformBlockBindings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorPoolInlineUniformBlockCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
