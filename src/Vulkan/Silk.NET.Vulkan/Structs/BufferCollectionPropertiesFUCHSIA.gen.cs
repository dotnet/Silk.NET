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
    [NativeName("Name", "VkBufferCollectionPropertiesFUCHSIA")]
    public unsafe partial struct BufferCollectionPropertiesFUCHSIA : IChainable
    {
        public BufferCollectionPropertiesFUCHSIA
        (
            StructureType? sType = StructureType.BufferCollectionPropertiesFuchsia,
            void* pNext = null,
            uint? memoryTypeBits = null,
            uint? bufferCount = null,
            uint? createInfoIndex = null,
            ulong? sysmemPixelFormat = null,
            FormatFeatureFlags? formatFeatures = null,
            SysmemColorSpaceFUCHSIA? sysmemColorSpaceIndex = null,
            ComponentMapping? samplerYcbcrConversionComponents = null,
            SamplerYcbcrModelConversion? suggestedYcbcrModel = null,
            SamplerYcbcrRange? suggestedYcbcrRange = null,
            ChromaLocation? suggestedXChromaOffset = null,
            ChromaLocation? suggestedYChromaOffset = null
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

            if (memoryTypeBits is not null)
            {
                MemoryTypeBits = memoryTypeBits.Value;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (createInfoIndex is not null)
            {
                CreateInfoIndex = createInfoIndex.Value;
            }

            if (sysmemPixelFormat is not null)
            {
                SysmemPixelFormat = sysmemPixelFormat.Value;
            }

            if (formatFeatures is not null)
            {
                FormatFeatures = formatFeatures.Value;
            }

            if (sysmemColorSpaceIndex is not null)
            {
                SysmemColorSpaceIndex = sysmemColorSpaceIndex.Value;
            }

            if (samplerYcbcrConversionComponents is not null)
            {
                SamplerYcbcrConversionComponents = samplerYcbcrConversionComponents.Value;
            }

            if (suggestedYcbcrModel is not null)
            {
                SuggestedYcbcrModel = suggestedYcbcrModel.Value;
            }

            if (suggestedYcbcrRange is not null)
            {
                SuggestedYcbcrRange = suggestedYcbcrRange.Value;
            }

            if (suggestedXChromaOffset is not null)
            {
                SuggestedXChromaOffset = suggestedXChromaOffset.Value;
            }

            if (suggestedYChromaOffset is not null)
            {
                SuggestedYChromaOffset = suggestedYChromaOffset.Value;
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
        [NativeName("Name", "memoryTypeBits")]
        public uint MemoryTypeBits;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferCount")]
        public uint BufferCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "createInfoIndex")]
        public uint CreateInfoIndex;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "sysmemPixelFormat")]
        public ulong SysmemPixelFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "formatFeatures")]
        public FormatFeatureFlags FormatFeatures;
/// <summary></summary>
        [NativeName("Type", "VkSysmemColorSpaceFUCHSIA")]
        [NativeName("Type.Name", "VkSysmemColorSpaceFUCHSIA")]
        [NativeName("Name", "sysmemColorSpaceIndex")]
        public SysmemColorSpaceFUCHSIA SysmemColorSpaceIndex;
/// <summary></summary>
        [NativeName("Type", "VkComponentMapping")]
        [NativeName("Type.Name", "VkComponentMapping")]
        [NativeName("Name", "samplerYcbcrConversionComponents")]
        public ComponentMapping SamplerYcbcrConversionComponents;
/// <summary></summary>
        [NativeName("Type", "VkSamplerYcbcrModelConversion")]
        [NativeName("Type.Name", "VkSamplerYcbcrModelConversion")]
        [NativeName("Name", "suggestedYcbcrModel")]
        public SamplerYcbcrModelConversion SuggestedYcbcrModel;
/// <summary></summary>
        [NativeName("Type", "VkSamplerYcbcrRange")]
        [NativeName("Type.Name", "VkSamplerYcbcrRange")]
        [NativeName("Name", "suggestedYcbcrRange")]
        public SamplerYcbcrRange SuggestedYcbcrRange;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "suggestedXChromaOffset")]
        public ChromaLocation SuggestedXChromaOffset;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "suggestedYChromaOffset")]
        public ChromaLocation SuggestedYChromaOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferCollectionPropertiesFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
