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
    [NativeName("Name", "VkDescriptorSetLayoutCreateInfo")]
    public unsafe partial struct DescriptorSetLayoutCreateInfo : IChainStart
    {
        public DescriptorSetLayoutCreateInfo
        (
            StructureType? sType = StructureType.DescriptorSetLayoutCreateInfo,
            void* pNext = null,
            DescriptorSetLayoutCreateFlags? flags = null,
            uint? bindingCount = null,
            DescriptorSetLayoutBinding* pBindings = null
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

            if (bindingCount is not null)
            {
                BindingCount = bindingCount.Value;
            }

            if (pBindings is not null)
            {
                PBindings = pBindings;
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
        [NativeName("Type", "VkDescriptorSetLayoutCreateFlags")]
        [NativeName("Type.Name", "VkDescriptorSetLayoutCreateFlags")]
        [NativeName("Name", "flags")]
        public DescriptorSetLayoutCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindingCount")]
        public uint BindingCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorSetLayoutBinding*")]
        [NativeName("Type.Name", "VkDescriptorSetLayoutBinding")]
        [NativeName("Name", "pBindings")]
        public DescriptorSetLayoutBinding* PBindings;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorSetLayoutCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DescriptorSetLayoutCreateInfo Chain(
            out DescriptorSetLayoutCreateInfo capture)
        {
            capture = new DescriptorSetLayoutCreateInfo(StructureType.DescriptorSetLayoutCreateInfo);
            return ref capture;
        }
    }
}
