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
    [NativeName("Name", "VkSamplerYcbcrConversionImageFormatPropertiesKHR")]
    [NativeName("AliasOf", "VkSamplerYcbcrConversionImageFormatProperties")]
    public unsafe partial struct SamplerYcbcrConversionImageFormatPropertiesKHR : IExtendsChain<ImageFormatProperties2>, IExtendsChain<ImageFormatProperties2KHR>
    {
        public SamplerYcbcrConversionImageFormatPropertiesKHR
        (
            StructureType? sType = StructureType.SamplerYcbcrConversionImageFormatProperties,
            void* pNext = null,
            uint? combinedImageSamplerDescriptorCount = null
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

            if (combinedImageSamplerDescriptorCount is not null)
            {
                CombinedImageSamplerDescriptorCount = combinedImageSamplerDescriptorCount.Value;
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
        [NativeName("Name", "combinedImageSamplerDescriptorCount")]
        public uint CombinedImageSamplerDescriptorCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerYcbcrConversionImageFormatProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
