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
    [NativeName("Name", "VkDescriptorSetVariableDescriptorCountAllocateInfoEXT")]
    [NativeName("AliasOf", "VkDescriptorSetVariableDescriptorCountAllocateInfo")]
    public unsafe partial struct DescriptorSetVariableDescriptorCountAllocateInfoEXT : IExtendsChain<DescriptorSetAllocateInfo>
    {
        public DescriptorSetVariableDescriptorCountAllocateInfoEXT
        (
            StructureType? sType = StructureType.DescriptorSetVariableDescriptorCountAllocateInfo,
            void* pNext = null,
            uint? descriptorSetCount = null,
            uint* pDescriptorCounts = null
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

            if (descriptorSetCount is not null)
            {
                DescriptorSetCount = descriptorSetCount.Value;
            }

            if (pDescriptorCounts is not null)
            {
                PDescriptorCounts = pDescriptorCounts;
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
        [NativeName("Name", "descriptorSetCount")]
        public uint DescriptorSetCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDescriptorCounts")]
        public uint* PDescriptorCounts;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorSetVariableDescriptorCountAllocateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
