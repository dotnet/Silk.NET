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
    [NativeName("Name", "VkDescriptorSetLayoutHostMappingInfoVALVE")]
    public unsafe partial struct DescriptorSetLayoutHostMappingInfoVALVE : IChainable
    {
        public DescriptorSetLayoutHostMappingInfoVALVE
        (
            StructureType? sType = StructureType.DescriptorSetLayoutHostMappingInfoValve,
            void* pNext = null,
            nuint? descriptorOffset = null,
            uint? descriptorSize = null
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

            if (descriptorOffset is not null)
            {
                DescriptorOffset = descriptorOffset.Value;
            }

            if (descriptorSize is not null)
            {
                DescriptorSize = descriptorSize.Value;
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
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "descriptorOffset")]
        public nuint DescriptorOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorSize")]
        public uint DescriptorSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DescriptorSetLayoutHostMappingInfoValve;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
