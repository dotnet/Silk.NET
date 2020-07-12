// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAndroidHardwareBufferFormatPropertiesANDROID")]
    public unsafe partial struct AndroidHardwareBufferFormatPropertiesANDROID
    {
        public AndroidHardwareBufferFormatPropertiesANDROID
        (
            StructureType sType = StructureType.AndroidHardwareBufferFormatPropertiesAndroid,
            void* pNext = default,
            Format format = default,
            ulong externalFormat = default,
            FormatFeatureFlags formatFeatures = default,
            ComponentMapping samplerYcbcrConversionComponents = default,
            SamplerYcbcrModelConversion suggestedYcbcrModel = default,
            SamplerYcbcrRange suggestedYcbcrRange = default,
            ChromaLocation suggestedXChromaOffset = default,
            ChromaLocation suggestedYChromaOffset = default
        )
        {
            SType = sType;
            PNext = pNext;
            Format = format;
            ExternalFormat = externalFormat;
            FormatFeatures = formatFeatures;
            SamplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
            SuggestedYcbcrModel = suggestedYcbcrModel;
            SuggestedYcbcrRange = suggestedYcbcrRange;
            SuggestedXChromaOffset = suggestedXChromaOffset;
            SuggestedYChromaOffset = suggestedYChromaOffset;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "externalFormat")]
        public ulong ExternalFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "formatFeatures")]
        public FormatFeatureFlags FormatFeatures;
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
    }
}
