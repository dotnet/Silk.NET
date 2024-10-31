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
    [NativeName("Name", "VkDescriptorSetLayoutBindingFlagsCreateInfoEXT")]
    [NativeName("AliasOf", "VkDescriptorSetLayoutBindingFlagsCreateInfo")]
    public unsafe partial struct DescriptorSetLayoutBindingFlagsCreateInfoEXT : IExtendsChain<DescriptorSetLayoutCreateInfo>
    {
        public DescriptorSetLayoutBindingFlagsCreateInfoEXT
        (
            StructureType? sType = StructureType.DescriptorSetLayoutBindingFlagsCreateInfo,
            void* pNext = null,
            uint? bindingCount = null,
            DescriptorBindingFlags* pBindingFlags = null
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

            if (bindingCount is not null)
            {
                BindingCount = bindingCount.Value;
            }

            if (pBindingFlags is not null)
            {
                PBindingFlags = pBindingFlags;
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
        [NativeName("Name", "bindingCount")]
        public uint BindingCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorBindingFlags*")]
        [NativeName("Type.Name", "VkDescriptorBindingFlags")]
        [NativeName("Name", "pBindingFlags")]
        public DescriptorBindingFlags* PBindingFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorSetLayoutBindingFlagsCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
